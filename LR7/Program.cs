
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

        private delegate Dictionary<int, int> NumberOfEnters(int[] massiv);

        public static void Main()
        {
            
            //Первая задача
            Func<bool, int> func = (flag) => flag ? 5 : 2;
            
            Action<Func<bool, int>, char, string> action = DoSomething;

            action(func, 'a', "Args");

            // Вторая задача

            string[] strings = new string[4];

            strings[0] = "Misha";
            strings[1] = "Alexey";
            strings[2] = "Matvey";
            strings[3] = "Slenderman";



            StringDelegate stringDelegate = (strings) => strings.OrderBy(s => s.Length).Last();

            Console.WriteLine($"Самая длинная строка: {stringDelegate(strings)}");
            // Вторая задача

            int[] massiv = { 1, 1, 2, 3, 3, 5 };


            // Третья задача
            NumberOfEnters dictDelegate = (massiv) => 
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                
                

                foreach (int i in massiv)
                {
                    dict[i] = massiv.Count(s => s == i);
                }

                return dict;
            };

            Dictionary<int, int> dict = dictDelegate(massiv);
            
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            
            // Третья задача


        }



    }

}