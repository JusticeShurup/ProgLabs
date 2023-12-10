namespace LR11
{
    public class Vector
    {
        public int x; 
        public int y;
        public int z;

        public Vector(int x, int y, int z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(15, 1, 5);
            Vector vector2 = new Vector(51, 2, 165);

            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => CalculateSkalyar(vector1, vector2));
                threads[i].Start();
            }
        }

        static void CalculateSkalyar(Vector vector1, Vector vector2)
        {
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} начал выполнение");
            int result = vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} произвёл вычисления. Результат скалярного произведения: {result}");
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} закончил выполнение");
        }
    }
}