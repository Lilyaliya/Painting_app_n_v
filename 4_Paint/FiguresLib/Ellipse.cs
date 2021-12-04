using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Ellipse: Circle
    {
        private int lY { get; set; } //полуось y
        public Ellipse()
        {
            Random rnd = new Random();
            r = rnd.Next(2, width / 2);
            lY = rnd.Next(2, heigth / 2);
            coords = new Point(rnd.Next(Math.Abs(width - 2 * r)),
                                    rnd.Next(Math.Abs(heigth - 2 * lY)));
            initXY(coords);
        }
        public Ellipse(Point coords, int x, int y)
        {
            this.coords = coords;
            r = x;
            lY = y;
            initXY(this.coords);
        }
        public override void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            gc.DrawEllipse(pen, X, Y, r, lY);
        }

        public override void Show(Graphics gc, Color color)
        {
            Pen pen1 = new Pen(color, 3);
            gc.DrawEllipse(pen1, X, Y, r, lY);
        }

        public override void MoveTo(Point point)
        {
            int x = this.X + point.getX();
            int y = this.Y + point.getY();
            coords.SetX(x);
            coords.SetY(y);
            initXY(coords);
        }
        ~Ellipse() { }

        public int getX() => r;
        public int getY() => lY;
        public new void Set(int[] paramets)
        {
            coords = new Point(paramets[0], paramets[1]);
            this.r = paramets[2];
            this.lY = paramets[3];
            initXY(coords);
        }

        public void Rotate()
        {
            X = X + r / 2 - lY / 2;
            Y = Y - r / 2 + lY / 2;
            int a = this.r;
            this.r = this.lY;
            this.lY = a;
        }
    }
}
