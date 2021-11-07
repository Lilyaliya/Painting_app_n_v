using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Trapeze: Square
    {
        private int x2;  // вторая сторона трапеции
        private int a;  // половина разности сторон
        private int h; // расстояние между сторонами
        private int max; // большая сторона
        public Trapeze()
        {
            Random rnd = new Random();
            x = rnd.Next(10, width / 2);
            x2 = rnd.Next(10, width / 2);
            max = (x > x2) ? x : x2;
            a = Math.Abs(x2 - x) / 2;
            h = Convert.ToInt32(a * Math.Sqrt(3));
            coords = new Point(rnd.Next(Math.Abs((x== max)? width - x : width - x - a)),
                                    rnd.Next(Math.Abs(heigth - h)));
            initXY(coords);
        }

    }
}
