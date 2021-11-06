using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public abstract class TFigure
    {
        protected const int width = 740;
        protected const int heigth = 572;
        public int X { get; set; }
        public int Y { get; set; }
        public void initXY(Point p) 
        {
            X = p.getX();
            Y = p.getY();
        }
        public TFigure() { }
        public abstract void Show(Graphics gc);

        public abstract void Show(Graphics gc, Color cl);
        public abstract void MoveTo(Point pt);
    }
}
