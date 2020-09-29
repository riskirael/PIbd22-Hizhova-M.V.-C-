using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class SeaPlane
    {
        private float startPosX;
        private float startPosY;
        private int pictureWidth = 100;
        private int pictureHeight = 60;
        private readonly int aircraftWidth = 120;
        private readonly int aircraftHeight = 95;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Bobber { private set; get; }
        public bool Stripes { private set; get; }
        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool bobber, bool stripes)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bobber = bobber;
            Stripes = stripes;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            if (x >= 0 && x + pictureWidth < width && y >= 0 && y + pictureHeight < height)
            {
                startPosX = x;
                startPosY = y;
                pictureWidth = width;
                pictureHeight = height;
            }
        }
        public void MoveTransport(Direction direc)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direc)
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
        public void DrawTransport(Graphics g)
        {
            Brush mainColor = new SolidBrush(MainColor);
            Brush dopColor = new SolidBrush(DopColor);
            Pen bl = new Pen(Color.Black);
            Pen gr = new Pen(Color.White);
            //поплавки
            if (Bobber)
            {
                g.FillRectangle(dopColor, startPosX + 45, startPosY + 25, 50, 10);
                g.FillRectangle(dopColor, startPosX + 45, startPosY + 75, 50, 10);
                //верхние
                g.DrawLine(bl, startPosX + 45, startPosY + 35, startPosX + 60, startPosY + 30);
                g.DrawLine(bl, startPosX + 45, startPosY + 25, startPosX + 60, startPosY + 30);
                g.DrawLine(bl, startPosX + 95, startPosY + 35, startPosX + 80, startPosY + 30);
                g.DrawLine(bl, startPosX + 95, startPosY + 25, startPosX + 80, startPosY + 30);
                //нижние
                g.DrawLine(bl, startPosX + 45, startPosY + 85, startPosX + 60, startPosY + 80);
                g.DrawLine(bl, startPosX + 45, startPosY + 75, startPosX + 60, startPosY + 80);
                g.DrawLine(bl, startPosX + 95, startPosY + 85, startPosX + 80, startPosY + 80);
                g.DrawLine(bl, startPosX + 95, startPosY + 75, startPosX + 80, startPosY + 80);
            }
            //корпус
            g.FillRectangle(mainColor, startPosX, startPosY + 45, 100, 20);
            g.DrawLine(gr, startPosX + 80, startPosY + 5, startPosX + 80, startPosY + 105);
            g.DrawLine(gr, startPosX + 59, startPosY + 5, startPosX + 59, startPosY + 105);
            //крылья
            g.FillRectangle(mainColor, startPosX + 60, startPosY + 5, 20, 100);
            //нос
            g.FillEllipse(mainColor, startPosX + 90, startPosY + 45, 20, 20);
            g.DrawLine(bl, startPosX + 110, startPosY + 35, startPosX + 110, startPosY + 75);
            //хвост
            g.FillRectangle(mainColor, startPosX - 5, startPosY + 35, 10, 40);
            g.DrawLine(bl, startPosX + 5, startPosY + 35, startPosX + 15, startPosY + 45);
            g.DrawLine(bl, startPosX + 5, startPosY + 75, startPosX + 15, startPosY + 65);
            g.DrawLine(gr, startPosX - 5, startPosY + 35, startPosX - 5, startPosY + 75);
            g.DrawLine(gr, startPosX + 5, startPosY + 35, startPosX + 5, startPosY + 75);

            //разметка
            if (Stripes)
            {
                g.DrawLine(gr, startPosX + 70, startPosY + 5, startPosX + 70, startPosY + 105);
                g.DrawLine(gr, startPosX + 72, startPosY + 5, startPosX + 72, startPosY + 105);
                g.DrawLine(gr, startPosX + 74, startPosY + 5, startPosX + 74, startPosY + 105);
                g.DrawLine(gr, startPosX + 76, startPosY + 5, startPosX + 76, startPosY + 105);
            }
        }
    }
}