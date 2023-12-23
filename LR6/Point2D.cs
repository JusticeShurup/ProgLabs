using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Point2D : Pair
    {

        public float X => Value1;
        public float Y => Value2;

        public Point2D(float x, float y)
            : base(x, y) {}

        public override void Print()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public override void Add(Pair other)
        {
            if (other is Point2D)
            {
                Value1 += (float)other.Value1;
                Value2 += (float)other.Value2;
            }
        }

        public override void Substract(Pair other)
        {
            if (other is Point2D)
            {
                Value1 -= (float)other.Value1;
                Value2 -= (float)other.Value2;
            }
        }

        public static Point2D operator+(Point2D left, Point2D right)
        {
            return new Point2D(left.X + right.Y, left.X + right.Y);
        }



    }
}
