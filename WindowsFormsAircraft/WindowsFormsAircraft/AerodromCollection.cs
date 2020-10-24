using System;
using System.Collections.Generic;
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
        public AerodromCollection(int pictureWidth, int pictureHeight)
        {
            aerodromStages = new Dictionary<string, Aerodrom<Plane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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
        public Aerodrom<Plane> this[int index]
        {
            get
            {
                if (index>-1&&index<aerodromStages.Count)
                {
                    return aerodromStages[Keys[index]];
                }
                return null;
            }
        }
    }
}

