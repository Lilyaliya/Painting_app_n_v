using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint._2._0
{
    class FiguresM
    {
        public object[] AddFigure(object[] figures, object obj)
        {
            if (figures == null)
            {
                figures = new object[1];
                figures[0] = obj;
                return (figures);
            }
            else
            {
                object[] figures2 = new object[figures.Length + 1];
                for (int i = 0; i <figures.Length; i++)
                    figures2[i] = figures[i];
                figures2[figures.Length] = obj;
                return (figures2);
            }
        }

        public object[] RemoveFigure(object[] figures, int index)
        {
            object[] figures2 = new object[figures.Length - 1];
            for (int i = 0; i < index; i++)
                figures2[i] = figures[i];
            for (int i = index; i < figures.Length - 1; i++)
            {
                figures2[i] = figures[i + 1];
            }
            return (figures2);
        }
    }
}
