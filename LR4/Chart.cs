using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Chart
    {
        
        public float CalculateIntegral(int a, int b)
        {
            return (float)(b * b) / 2 - (float)(a * a) / 2;
        }

        public float CalculateLenght(int a, int b)
        {
            return (float)Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(b - a, 2));
        }

    }
}
