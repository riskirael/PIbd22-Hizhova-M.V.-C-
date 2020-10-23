using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public class Aerodrom<T> where T : class, ITransport
    {
        private readonly T[] places;
        private readonly int pictureWidth = 140;
        private readonly int pictureHeight = 90;
        private readonly int placeSizeWidth = 150;
        private readonly int placeSizeHeight = 120;
        public Aerodrom(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        public static bool operator +(Aerodrom<T> a, T aircraft)
        {
            int x = 10;
            int rowsCount = a.pictureHeight / a.placeSizeHeight;
            for (int i = 0; i < a.places.Length; i++)
            {
                if (a.places[i] == null)
                {
                    aircraft.SetPosition(x+ a.placeSizeWidth * (i / rowsCount), x+ a.placeSizeHeight * (i % rowsCount), a.pictureWidth, a.pictureHeight);
                    a.places[i] = aircraft;
                    return true;
                }
            }
            return false;
        }
        public static T operator -(Aerodrom<T> a, int index)
        {
            if (index >= 0 && index <a.places.Length && a.places[index] != null)
            {
                T temp = a.places[index];
                a.places[index] = null;
                return temp;
            }
            return null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                places[i]?.DrawTransport(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Green, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i *placeSizeWidth + placeSizeWidth / 2+20,
                        j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth,
               (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }
    }
}