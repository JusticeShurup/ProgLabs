using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Chart
    {

        public float a { get; set; }
        public float b { get; set; }


        public float CalculateIntegral()
        {
            return (float)(b * b) / 2 - (float)(a * a) / 2;
        }

        public float CalculateLength()
        {
            return (float)Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(b - a, 2));
        }

    }
}
