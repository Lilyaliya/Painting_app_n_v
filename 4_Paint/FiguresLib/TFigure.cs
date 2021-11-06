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
        public int X { get; set; }
        public int Y { get; set; }
        public TFigure(Point p, int x) { }
        public TFigure() { }
        public TFigure(int x) { }
        public abstract void Show(Graphics gc);

        public abstract void Show(Graphics gc, Color cl);
        public abstract void MoveTo(Point pt);
    }
}
