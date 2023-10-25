using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Point2D : APair
    {
        public float x;
        public float y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Print()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public static Point2D operator+(Point2D left, Point2D right)
        {
            return new Point2D(left.x + right.x, left.y + right.y);
        }



    }
}
