using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Trapeze: Square // равнобедренная трапеция
    {
        private int x2;        // второе основание трапеции
        private int a;        // половина разности оснований
        private int h;       // расстояние между основаниями
        private int max;    // большее основание
        private bool ornt;
        public Trapeze()
        {
            Random rnd = new Random();
            x = rnd.Next(8, width / 2);
            x2 = rnd.Next(10, width / 2);
            max = (x > x2) ? x : x2;
            ornt = (x >= x2) ? true : false;
            a = Math.Abs(x2 - x) / 2;
            h = Convert.ToInt32(a * Math.Sqrt(3));
            coords = new Point(rnd.Next(Math.Abs((x== max)? Math.Abs(width - x) : Math.Abs(width - x - a))),
                                    rnd.Next(Math.Abs(heigth - h)));
            initXY(coords);
        }

        public Trapeze(Point point, int x, int h)
        {
            this.h = h;
            this.x = x;
            x2 = Convert.ToInt32((2 * this.h) / Math.Sqrt(3) + this.x);
            max = (this.x > x2) ? this.x : x2;
            a = Math.Abs(x2 - x) / 2;
            coords = point;
            initXY(coords);
        }

        public new void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + a, this.Y);
            gc.DrawLine(pen, this.X + a, this.Y, this.X + max - a, this.Y);
            gc.DrawLine(pen, this.X + max - a, this.Y, this.X + max, this.Y + h);
            gc.DrawLine(pen, this.X + max, this.Y + h, this.X, this.Y + h);
        }

        public new void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 3);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + a, this.Y);
            gc.DrawLine(pen, this.X + a, this.Y, this.X + max - a, this.Y);
            gc.DrawLine(pen, this.X + max - a, this.Y, this.X + max, this.Y + h);
            gc.DrawLine(pen, this.X + max, this.Y + h, this.X, this.Y + h);
        }


        public override void MoveTo(Point point)
        {
            int x = coords.getX() + point.getX();
            int y = coords.getY() + point.getY();
            coords.SetX(x);
            coords.SetY(y);
            initXY(this.coords);
        }
        ~Trapeze() { }
        public int[] getSize() { return (new int[] { x, x2}); }
        public int geta() => a;

        public Point getHigh() { return (coords); }
        public int getMin() => (x < x2) ? x : x2;
        public int getH() => h;
        public void SetX(int x) { this.x = x; }

        public void SetH(int h)
        {
            this.h = h;
        }

    }
}
