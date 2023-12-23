using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class Series
    {
        public List<Pair> pairs;

        public Series()
        {
            pairs = new List<Pair>();
            pairs.Add(new Cell(1, 5));
            pairs.Add(new Point2D(5, 1));
            pairs.Add(new Cell(2, 2));
            pairs.Add(new Point2D(10, 10));
            pairs.Add(new Cell(3, 1));
            pairs.Add(new Point2D(123, 2));
        }

        public void PrintAllPairs()
        {
            foreach (var pair in pairs)
            {
                pair.Print();
            }
        }

    }
}
