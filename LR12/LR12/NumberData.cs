using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR12
{
    internal class NumberData
    {
        private List<int> numbers;

        public NumberData() 
        {
            numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(new Random().Next());
            }

        }

        public void Add(int value)
        {
            numbers.Add(value);
            ThreadPool.QueueUserWorkItem(MethodForThread, value);
        }

        public void MethodForThread(object ob)
        {
            NumberProccessor numberProccessor = new NumberProccessor();

            numberProccessor.ProcessNumbers(numbers);

        }


    }
}
