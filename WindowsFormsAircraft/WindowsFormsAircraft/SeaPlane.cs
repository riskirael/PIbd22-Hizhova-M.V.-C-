using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class SeaPlane : Aircraft
    {
        public Color DopColor { private set; get; }
        public bool Bobber { private set; get; }
        public bool Stripes { private set; get; }
        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor,bool bobber, bool stripes) :
            base(maxSpeed, weight, mainColor, 120, 70)
        {
            DopColor = dopColor;
            Bobber = bobber;
            Stripes = stripes;
        }
       
        public override void DrawTransport(Graphics g)
        {
            Brush dopColor = new SolidBrush(DopColor);
            Pen bl = new Pen(Color.Black);
            Pen gr = new Pen(Color.White);
            //поплавки
            if (Bobber)
            {
                g.FillRectangle(dopColor, startPosX + 45, startPosY + 20, 50, 10);
                g.FillRectangle(dopColor, startPosX + 45, startPosY + 70,50, 10);
                //верхние
                g.DrawLine(bl, startPosX + 45, startPosY + 30, startPosX + 60, startPosY + 25);
                g.DrawLine(bl, startPosX + 45, startPosY + 20, startPosX + 60, startPosY + 25);
                g.DrawLine(bl, startPosX + 95, startPosY + 30, startPosX + 80, startPosY + 25);
                g.DrawLine(bl, startPosX + 95, startPosY + 20, startPosX + 80, startPosY + 25);
                //нижние
                g.DrawLine(bl, startPosX + 45, startPosY + 80, startPosX + 60, startPosY + 75);
                g.DrawLine(bl, startPosX + 45, startPosY + 70, startPosX + 60, startPosY + 75);
                g.DrawLine(bl, startPosX + 95, startPosY + 80, startPosX + 80, startPosY + 75);
                g.DrawLine(bl, startPosX + 95, startPosY + 70, startPosX + 80, startPosY + 75);
            }
            base.DrawTransport(g);
            //разметка
            if (Stripes)
            {
                g.DrawLine(gr, startPosX + 70, startPosY, startPosX + 70, startPosY + 95);
                g.DrawLine(gr, startPosX + 72, startPosY, startPosX + 72, startPosY + 95);
                g.DrawLine(gr, startPosX + 74, startPosY, startPosX + 74, startPosY + 95);
                g.DrawLine(gr, startPosX + 76, startPosY, startPosX + 76, startPosY + 95);
            }
        }
    }
}