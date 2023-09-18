namespace LR4
{
    public class Program 
    {
        public static void FirstTask()
        {
            Chart chart = new Chart();
            Console.Write("Введите левую границу a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите правую границу b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Интеграл функции y = x от a до b равен {0}", chart.CalculateIntegral(a, b));

        }

        public static void SecondTask() 
        {
            Money money = new(100, 100);
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            money++;
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            money--;
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            Console.WriteLine(!money);
            money += 500;
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
        }

        public static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }
    }
}