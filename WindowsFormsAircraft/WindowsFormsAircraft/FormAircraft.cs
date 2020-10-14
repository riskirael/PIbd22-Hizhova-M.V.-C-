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
    public partial class FormAircraft : Form
    {
        private Aircraft aircraft;
        public FormAircraft()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawTransport(gr);
            pictureBoxAircraft.Image = bmp;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    aircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateSeaPlane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new SeaPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
            Color.Yellow, true, true);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width,
            pictureBoxAircraft.Height);
            Draw();
        }

        private void buttonCreateAircraft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            aircraft = new Aircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            Draw();
        }
    }
}
