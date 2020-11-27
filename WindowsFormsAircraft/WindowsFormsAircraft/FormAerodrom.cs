using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAircraft
{
    public partial class FormAerodrom : Form
    {
        private readonly AerodromCollection aerodromCollection;
        private readonly Logger logger;
        public FormAerodrom()
        {
            InitializeComponent();
            aerodromCollection = new AerodromCollection(pictureBoxAerodrom.Width,pictureBoxAerodrom.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        private void ReloadLevels()
        {
            int index = listBoxAerodrom.SelectedIndex;
            listBoxAerodrom.Items.Clear();
            for (int i = 0; i < aerodromCollection.Keys.Count; i++)
            {
                listBoxAerodrom.Items.Add(aerodromCollection.Keys[i]);
            }
            if (listBoxAerodrom.Items.Count > 0 && (index == -1 || index >=
            listBoxAerodrom.Items.Count))
            {
                listBoxAerodrom.SelectedIndex = 0;
            }
            else if (listBoxAerodrom.Items.Count > 0 && index > -1 && index <
            listBoxAerodrom.Items.Count)
            {
                listBoxAerodrom.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxAerodrom.SelectedIndex > -1)
            { 
                Bitmap bmp = new Bitmap(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodromCollection[listBoxAerodrom.SelectedItem.ToString()].Draw(gr);
                pictureBoxAerodrom.Image = bmp;
            }
        }
        private void buttonSetAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrom.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var aircraft = new Aircraft(100, 1000, dialog.Color);
                    if (aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] +aircraft)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Аэродром переполнен");
                    }
                }
            }
        }
        private void buttonSetSeaPlane_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrom.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var aircraft = new SeaPlane(100, 1000, dialog.Color,
                        dialogDop.Color, true, true);
                        if (aerodromCollection[listBoxAerodrom.SelectedItem.ToString()]+aircraft)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Аэродром переполнен");
                        }
                    }
                }
            }
        }
        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrom.SelectedIndex > -1 && maskedTextBox1.Text != "")
            {
                try
                {
                    var aircraft =aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] -
                    Convert.ToInt32(maskedTextBox1.Text);
                    if (aircraft != null)
                    {
                        FormAircraft form = new FormAircraft();
                        form.SetAircraft(aircraft);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {aircraft} с места { maskedTextBox1.Text}");
                    Draw();
                    }
                }
                catch (AerodromNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
                }
            }
        }

        private void buttonAddAerodrom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAerodrom.Text))
            {
                logger.Warn("Не введено название аэродрома");
                MessageBox.Show("Введите название аэродрома", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили аэродром {textBoxAerodrom.Text}");
            aerodromCollection.AddParking(textBoxAerodrom.Text);
            ReloadLevels();
        }

        private void buttonDelAerodrom_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrom.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром {listBoxAerodrom.SelectedItem}?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили аэродром{listBoxAerodrom.SelectedItem.ToString()}");
                    aerodromCollection.DelParking(textBoxAerodrom.Text);
                    ReloadLevels();
                }
            }
        }
        private void listBoxAerodrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на аэродром{ listBoxAerodrom.SelectedItem.ToString()} ");
            Draw();
        }

        private void buttonAddAircraft_Click(object sender, EventArgs e)
        {
            var formAircraftConfig = new FormAircraftConfig();
            formAircraftConfig.AddEvent(AddAircraft);
            formAircraftConfig.Show();
        }
        private void AddAircraft(Plane aircraft)
        {
            if (aircraft != null && listBoxAerodrom.SelectedIndex > -1)
            {
                try
                {
                    if ((aerodromCollection[listBoxAerodrom.SelectedItem.ToString()]) +aircraft)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {aircraft}");
                    }
                    else
                    {
                        MessageBox.Show("Самолет не удалось посадить");
                    }
                    Draw();
                }
                catch (AerodromOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (AerodromOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занято место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logger.Warn("Место занято");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении");
                }
            }
        }
    }
}
