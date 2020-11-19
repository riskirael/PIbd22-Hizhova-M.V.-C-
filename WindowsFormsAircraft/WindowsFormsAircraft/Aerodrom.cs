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
        private readonly List<T> places;
        private readonly int maxCount;
        private readonly int pictureWidth = 140;
        private readonly int pictureHeight = 90;
        private readonly int placeSizeWidth = 150;
        private readonly int placeSizeHeight = 120;
        public Aerodrom(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            places = new List<T>();
        }
        public static bool operator +(Aerodrom<T> a, T aircraft)
        {
            if (a.places.Count >= a.maxCount)
            {
                return false;
            }
            a.places.Add(aircraft);
            return true;
        }
        public static T operator -(Aerodrom<T> a, int index)
        {
            if (index < -1 || index > a.places.Count)
            {
                return null;
            }
            T aircraft = a.places[index];
            a.places.RemoveAt(index);
            return aircraft;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(5 + i / 5 * placeSizeWidth + 15, i % 5 *
                placeSizeHeight +15, pictureWidth, pictureHeight);
                places[i].DrawTransport(g);
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
        public T GetNext(int index)
        {
            if (index < 0 || index >= places.Count)
            {
                return null;
            }
            return places[index];
        }
    }
}