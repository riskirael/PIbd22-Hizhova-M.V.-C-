using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class AerodromCollection
    {
        readonly Dictionary<string, Aerodrom<Plane>> aerodromStages;
        public List<string> Keys => aerodromStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';
        private readonly Logger logger;
        public AerodromCollection(int pictureWidth, int pictureHeight)
        {
            aerodromStages = new Dictionary<string, Aerodrom<Plane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            logger = LogManager.GetCurrentClassLogger();
        }
        public void AddParking(string name)
        {
            if (aerodromStages.ContainsKey(name))
            {
                return;
            }
            aerodromStages.Add(name, new Aerodrom<Plane>(pictureWidth, pictureHeight));
        }
        public void DelParking(string name)
        {
            if (aerodromStages.ContainsKey(name))
            {
                aerodromStages.Remove(name);
            }
        }
        public Aerodrom<Plane> this[string index]
        {
            get
            {
                if (aerodromStages.ContainsKey(index))
                {
                    return aerodromStages[index];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write($"AerodromCollection{Environment.NewLine}");
                foreach (var level in aerodromStages)
                {
                    sw.Write($"Aerodrom{separator}{level.Key}{Environment.NewLine}");
                    ITransport aircraft = null;
                    for (int i = 0; (aircraft = level.Value.GetNext(i)) != null; i++)
                    {
                        if (aircraft != null)
                        {
                            if (aircraft.GetType().Name == "Aircraft")
                            {
                                sw.Write($"Aircraft{separator}");
                            }
                            if (aircraft.GetType().Name == "SeaPlane")
                            {
                                sw.Write($"SeaPlane{separator}");
                            }
                            sw.Write(aircraft + Environment.NewLine);
                        }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                logger.Warn("Файл не найден");
                throw new FileNotFoundException();
            }
            using (StreamReader streamReader = new StreamReader(filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("AerodromCollection"))
                {
                    aerodromStages.Clear();
                }
                else
                {
                    logger.Warn("Неверный формат файла");
                    throw new FormatException("Неверный формат файла");
                }

                Aircraft aircraft = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Aerodrom"))
                    {
                        key = line.Split(separator)[1];
                        aerodromStages.Add(key, new Aerodrom<Plane>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Aircraft"))
                        {
                            aircraft = new Aircraft(line.Split(separator)[1]);
                        }
                        else if (line.Contains("SeaPlane"))
                        {
                            aircraft = new SeaPlane(line.Split(separator)[1]);
                        }
                        if (!(aerodromStages[key] + aircraft))
                        {
                            logger.Warn("Не удалось загрузить самолет на аэродром");
                            throw new NullReferenceException("Не удалось загрузить самолет на аэродром");
                            
                        }
                    }
                }
            }
        }
    }
}

