using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    
    public abstract class Pair
    {
        public dynamic Value1 { get; set; }
        public dynamic Value2 { get; set; }

        public Pair(dynamic value1, dynamic value2)
        {
            Value1 = value1;
            Value2 = value2;
        }


        public abstract void Add(Pair other);
        public abstract void Substract(Pair other);

        public abstract void Print();

        public bool Equals(Pair other)
        {
            return Value1 == other.Value1;
        }


    }
}