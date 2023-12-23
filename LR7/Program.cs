
using System.Security.Principal;

namespace LR7
{

    public class Program
    {

        private static int ReturnSomething(bool flag)
        {
            return flag ? 1 : 0;
        }

        private static void DoSomething(Func<bool, int> someFunc, char someChar, string someString) 
        {
            int value = someFunc(true);

            string newString = new string(someString + String.Concat(Enumerable.Repeat(someChar, value)));

            Console.WriteLine(newString);
        }


        private delegate string StringDelegate(string[] strings);

        private delegate Dictionary<int, int> NumberOfEnters(int size);

        public static void Main()
        {

            Console.WriteLine("Первая задача: ");

            //Первая задача
            Func<bool, int> func = (flag) => flag ? 5 : 2;
            
            Action<Func<bool, int>, char, string> action = DoSomething;

            action(func, 'a', "Args");

            Console.WriteLine("\nВторая задача: ");
            // Вторая задача

            string[] strings = new string[4];

            strings[0] = "Misha";
            strings[1] = "Alexey";
            strings[2] = "Matvey";
            strings[3] = "Slenderman";



            StringDelegate stringDelegate = (strings) => strings.OrderBy(s => s.Length).Last();

            Console.WriteLine($"Самая длинная строка: {stringDelegate(strings)}");
            // Вторая задача




            Console.WriteLine("\nТретья задача: ");
            // Третья задача
            int size = 30;
            NumberOfEnters dictDelegate = (size) => 
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();

                int[] massiv = new int[size];

                for (int i = 0; i < size; i++)
                {
                    massiv[i] = new Random().Next(0, 10);
                }

                foreach (int i in massiv)
                {
                    dict[i] = massiv.Count(s => s == i);
                }

                return dict;
            };

            Console.WriteLine($"Количество вхождений массива из {size} чисел:"); ;

            Dictionary<int, int> dict = dictDelegate(size);
            
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            
            // Третья задача




        }



    }

}