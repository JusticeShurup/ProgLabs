using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Point2D : APair
    {
        public int x;
        public int y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Print()
        {
            Console.WriteLine($"Координата x = {x}\nКоордината y = {y}");
        }
    }
}
