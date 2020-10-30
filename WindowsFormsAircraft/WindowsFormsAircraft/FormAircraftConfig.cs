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
    public partial class FormAircraftConfig : Form
    {
        Plane aircraft = null;
        private event Action<Plane> eventAddAircraft;
        public FormAircraftConfig()
        {
            InitializeComponent();
            panelYellow.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;

            buttonCancelColor.Click += (object sender, EventArgs e) => { Close(); };
        }
        public void AddEvent(Action<Plane> ev)
        {
            if (eventAddAircraft == null)
            {
                eventAddAircraft = new Action<Plane>(ev);
            }
            else
            {
                eventAddAircraft += ev;
            }
        }
        private void DrawAircraft()
        {
            if (aircraft != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aircraft.SetPosition(5, 5, pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                aircraft.DrawTransport(gr);
                pictureBoxAircraft.Image = bmp;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                 DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraft.DoDragDrop(labelAircraft.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }
        private void labelSeaPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelSeaPlane.DoDragDrop(labelSeaPlane.Text, DragDropEffects.Move |DragDropEffects.Copy);
        }
        private void panelPicBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelPicBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    aircraft = new Aircraft((int)numericUpDownMaxSpeed.Value,(int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Гидросамолет":
                    aircraft = new SeaPlane((int)numericUpDownMaxSpeed.Value,
                    (int)numericUpDownWeight.Value, Color.White, Color.Black,
                    checkBoxBobber.Checked, checkBoxStripes.Checked);
                    break;
            }
            DrawAircraft();
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null)
            {
                aircraft.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAircraft();
            }
        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (aircraft != null)
            {
                if (aircraft is SeaPlane)
                {
                    (aircraft as SeaPlane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAircraft();
                }
            }

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddAircraft?.Invoke(aircraft);
            Close();
        }
    }
}
