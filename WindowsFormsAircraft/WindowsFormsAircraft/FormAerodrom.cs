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
        public FormAerodrom()
        {
            InitializeComponent();
            aerodromCollection = new AerodromCollection(pictureBoxAerodrom.Width,pictureBoxAerodrom.Height);
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
                var aircraft = aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] -
                Convert.ToInt32(maskedTextBox1.Text);
                if (aircraft != null)
                {
                    FormAircraft form = new FormAircraft();
                    form.SetAircraft(aircraft);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Пустое место");
                }
                Draw();
            }
        }

        private void buttonAddAerodrom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAerodrom.Text))
            {
                MessageBox.Show("Введите название аэродрома", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                    aerodromCollection.DelParking(textBoxAerodrom.Text);
                    ReloadLevels();
                }
            }
        }
        private void listBoxAerodrom_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                if ((aerodromCollection[listBoxAerodrom.SelectedItem.ToString()]) + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет не удалось посадить");
                }
            }
        }
    }
}