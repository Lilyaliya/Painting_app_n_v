﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FiguresLib
{
    public class Trapeze: Square
    {
        private int x2;  // второе основание трапеции
        private int a;  // половина разности оснований
        private int h; // расстояние между основаниями
        private int max; // большее основание
        public Trapeze()
        {
            Random rnd = new Random();
            x = rnd.Next(8, width / 2);
            x2 = rnd.Next(10, width / 2);
            max = (x > x2) ? x : x2;
            a = Math.Abs(x2 - x) / 2;
            h = Convert.ToInt32(a * Math.Sqrt(3));
            coords = new Point(rnd.Next(Math.Abs((x== max)? width - x : width - x - a)),
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
        public new void Show(Graphics gc, Color color, Point point)
        {
            Pen pen = new Pen(color, 3);
            this.coords = point;
            initXY(coords);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + x2, this.Y + h);
            gc.DrawLine(pen, this.X + x2, this.Y + h, this.X + x2 - a, this.Y);
            gc.DrawLine(pen, this.X + x2 - a, this.Y, this.X + a, this.Y);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + a, this.Y);
        }

        public new void Show(Graphics gc)
        {
            Pen pen = new Pen(Color.Green, 3);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + x2, this.Y + h);
            gc.DrawLine(pen, this.X + x2, this.Y + h, this.X + x2 - a, this.Y);
            gc.DrawLine(pen, this.X + x2 - a, this.Y, this.X + a, this.Y);
            gc.DrawLine(pen, this.X, this.Y + h, this.X + a, this.Y);
        }

    }
}
