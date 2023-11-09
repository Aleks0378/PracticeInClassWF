using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_09._11
{
    internal class Cinema
    {
        private bool[,] seats = new bool[30, 15];
        private const int size = 16;
        private const int space = 2;

        public int FormWidth
        {
            get
            {
                return seats.GetLength(0) + (size + space) + 16; ;
            }
        }

        public void Draw(Graphics g)
        {
            Brush brush;
            for (int j=0; j<seats.GetLength(1); j++) 
            {
                for (int i=0; i<seats.GetLength(0); i++)
                {
                    brush = seats[i, j] ? Brushes.Red : Brushes.Green;
                    g.FillRectangle(brush, i*(size+space), j*(size+space), size,size);
                }
            }
        }

        public void Draw(Graphics g, int x, int y)
        {
            Brush brush;
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    if((i*(size+space))-size<=x && (i*(size+space)+size>=x) && (j*(size+space))-size<=y && (j*(size+space))+size>=y)
                    {

                    }

                }
            }
        }
    }
}
