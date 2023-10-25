namespace LR4
{
    public class Program 
    {
        public static void FirstTask()
        {
            Chart chart = new Chart();
            Console.Write("Введите левую границу a: ");
            chart.a = int.Parse(Console.ReadLine());
            Console.Write("Введите правую границу b: ");
            chart.b = int.Parse(Console.ReadLine());

            Console.WriteLine("Интеграл функции y = x от a до b равен {0}", chart.CalculateIntegral());
            Console.WriteLine("Длина отрезка функции от a до b равна {0}", chart.CalculateLength());

        }

        public static void SecondTask() 
        {
            Money money = new(100, 100);
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            money++;
            Console.WriteLine("-----------------\nПроизошло увеличение");
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            money--;
            Console.WriteLine("-----------------\nПроизошло уменьшение");
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
            Console.WriteLine(!money);
            money += 500;
            Console.WriteLine("-----------------\nПроизошло увеличение на 500");
            Console.WriteLine($"Количество купюр: {money[2]}\nНоминал этих купюр: {money[1]}");
            Console.WriteLine($"Сумма денег: {money.value}");
        }

        public static void Main(string[] args)
        {
            FirstTask();
            Console.WriteLine("---------------\nВторое задание\n-------------");
            SecondTask();
        }
    }
}