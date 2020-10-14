using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAircraft
{
    public abstract class Plane : ITransport
    {
        protected float startPosX;
        protected float startPosY;
        protected int pictureWidth=120;
        protected int pictureHeight=90;
        
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
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
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}