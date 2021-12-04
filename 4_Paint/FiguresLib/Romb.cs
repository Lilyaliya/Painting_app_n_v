using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Romb: Square
    {
        private Point maxP;
        private Point lowP;
        public Romb()
        {
            Random rnd = new Random();
            this.x = rnd.Next(10, heigth / 2);
            maxP = new Point(rnd.Next(Math.Abs(width)),
                            rnd.Next(Math.Abs(heigth - x)));
            lowP = new Point(maxP.getX(), maxP.getY() + x);
        }

        public Romb(Point maxP, int x)
        {
            this.maxP = maxP;
            this.x = x;
            this.lowP = new Point(this.maxP.getX(), this.maxP.getY() + x);
        }

        public override void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            if (maxP != null && lowP != null)
            {
                gc.DrawLine(pen, maxP.getX(), maxP.getY(), maxP.getX() - x/2, maxP.getY() + x / 2);
                gc.DrawLine(pen, maxP.getX(), maxP.getY(), maxP.getX() + x/2, maxP.getY() + x / 2);
                gc.DrawLine(pen, lowP.getX(), lowP.getY(), lowP.getX() - x/2, lowP.getY() - x/2);
                gc.DrawLine(pen, lowP.getX(), lowP.getY(), lowP.getX() + x / 2, lowP.getY() - x / 2);
            }
        }

        public override void Show(Graphics gc, Color color)
        {
            Pen pen = new Pen(color, 3);
            if (maxP != null && lowP != null)
            {
                gc.DrawLine(pen, maxP.getX(), maxP.getY(), maxP.getX() - x / 2, maxP.getY() + x / 2);
                gc.DrawLine(pen, maxP.getX(), maxP.getY(), maxP.getX() + x / 2, maxP.getY() + x / 2);
                gc.DrawLine(pen, lowP.getX(), lowP.getY(), lowP.getX() - x / 2, lowP.getY() - x / 2);
                gc.DrawLine(pen, lowP.getX(), lowP.getY(), lowP.getX() + x / 2, lowP.getY() - x / 2);
            }
        }
        public override void MoveTo(Point point)
        {
            int x = maxP.getX() + point.getX();
            int y = maxP.getY() + point.getY();
            maxP.SetX(x);
            maxP.SetY(y);
            lowP = new FiguresLib.Point(maxP.getX(), maxP.getY() + this.x);
        }

        ~Romb() { }
        public int getSize() { return (x); }

        public Point getMax() { return (maxP); }

        public Point getLow() { return (lowP); }
        public new void Set(int l)
        {
            this.x = l;
        }
    }
}
