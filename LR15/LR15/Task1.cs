using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15
{
    partial class Zadanie
    {
        public static void Task1()
        {

            int[] X = Enumerable.Range(0, 10).Select(i => new Random().Next(10)).ToArray();
            Console.WriteLine("Массив X: ");
            X.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine("\nМассив Y: ");
            int[] Y = Array.Empty<int>();

            Y = Y.Concat(X.Where(x => x > (int)X.Average()).OrderByDescending(x => x)).ToArray();

            Y.ToList().ForEach(y => Console.Write($"{y} "));
        }

    }
}
