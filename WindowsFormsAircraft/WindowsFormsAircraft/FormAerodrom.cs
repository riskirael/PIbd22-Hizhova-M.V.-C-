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
        private readonly Aerodrom<Plane> aerodrom;
        public FormAerodrom()
        {
            InitializeComponent();
            aerodrom = new Aerodrom<Plane>(pictureBoxAerodrom.Width,pictureBoxAerodrom.Height);
            Draw();
        }
        
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aerodrom.Draw(gr);
            pictureBoxAerodrom.Image = bmp;
        }
        private void buttonSetAircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var aircraft = new Aircraft(100, 1000, dialog.Color);
                if (aerodrom + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Аэродром переполнен");
                }
            }
        }
        private void buttonSetSeaPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var aircraft = new SeaPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (aerodrom + aircraft)
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
        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var aircraft = aerodrom - Convert.ToInt32(maskedTextBox1.Text);
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
    }
}