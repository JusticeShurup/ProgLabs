using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR12
{
    internal class NumberProccessor
    {
        List<Task> tasks;
        
        public NumberProccessor() 
        {
        
            tasks = new List<Task>();
        }


        public void ProcessNumbers(List<int> numbers)
        {
            Task task = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Начался поиск подмножества четных чисел");

                List<int> newList = new List<int>();
                

                lock (numbers)
                {
                    foreach (int value in numbers)
                    {
                        if (value % 2 == 0)
                        {
                            newList.Add(value);
                        }
                    }
                }
                

                Console.WriteLine($"Поиск закончился, длина подмножества: {newList.Count}");
            });
            tasks.Add(task);
        }

        public void WaitForTasks()
        {
            Task.WaitAll(tasks.ToArray());
        }

    }
}
