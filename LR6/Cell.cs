using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    
    enum Letters
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }

    internal class Cell : Pair
    {

        public int Col => Value1;
        public int Row => Value2;



        public Cell(int collumn, int row) 
            : base(collumn, row) {} 
 

        public override void Print()
        {

            Console.WriteLine($"Столбец - {(Letters)Col}, Строка - {Row}");
        }

        public override void Add(Pair other)
        {
            if (other is Cell)
            {
                Value1 = Value1 + (int)other.Value1 % (int)Letters.Z;
                Value2 += (int)other.Value2;
            }
        }

        public override void Substract(Pair other)
        {
            if (other is Cell)
            {
                Value1 = Value1 - (int)other.Value1 < 0 ? (int)Letters.Z - Value1 : Value1 - (int)other.Value1;
                Value2 -= (int)other.Value2;
            }
        }
    }
}
