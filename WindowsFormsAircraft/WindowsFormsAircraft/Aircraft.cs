using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class Aircraft : Plane
    {
        protected readonly int aircraftWidth = 120;
        protected readonly int aircraftHeight =90;
        protected readonly char separator = ';';
        public Aircraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Aircraft(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        protected Aircraft(int maxSpeed, float weight, Color mainColor, int aircraftWidth, int aircraftHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.aircraftWidth = aircraftWidth;
            this.aircraftHeight = aircraftHeight;
        }
       
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (startPosX + aircraftWidth + step < pictureWidth)
                    {
                        startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (startPosX - step > 0)
                    {
                        startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (startPosY - step > 0)
                    {
                        startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (startPosY + aircraftHeight + step < pictureHeight)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(MainColor);
            Pen bl = new Pen(Color.Black);
            Pen gr = new Pen(Color.White);
            //корпус
            g.FillRectangle(mainColor, startPosX, startPosY + 40, 100, 20);
            g.DrawLine(gr, startPosX + 80, startPosY, startPosX + 80, startPosY + 95);
            g.DrawLine(gr, startPosX + 59, startPosY, startPosX + 59, startPosY + 95);
            //крылья
            g.FillRectangle(mainColor, startPosX + 60, startPosY, 20, 95);
            //нос
            g.FillEllipse(mainColor, startPosX + 90, startPosY + 40, 20, 20);
            g.DrawLine(bl, startPosX + 110, startPosY + 30, startPosX + 110, startPosY + 70);
            //хвост
            g.FillRectangle(mainColor, startPosX - 5, startPosY + 30, 10, 40);
            g.DrawLine(bl, startPosX + 5, startPosY + 30, startPosX + 15, startPosY + 40);
            g.DrawLine(bl, startPosX + 5, startPosY + 70, startPosX + 15, startPosY + 60);
            g.DrawLine(gr, startPosX - 5, startPosY + 30, startPosX - 5, startPosY + 70);
            g.DrawLine(gr, startPosX + 5, startPosY + 30, startPosX + 5, startPosY + 70);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
