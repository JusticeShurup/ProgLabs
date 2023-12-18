namespace LR14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Task<int[,]> generalTask = new Task<int[,]>(() =>
            {
                int[,] matrix = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = new Random().Next(9);
                    }
                }

                return matrix;
            });


            Task printMatrix = generalTask.ContinueWith(task =>
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write($"{task.Result[i, j]} ");
                    }
                    Console.WriteLine();    
                }
            });


            Task countElements = generalTask.ContinueWith(task =>
            {
                Thread.Sleep(100);
                int count = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        count += Convert.ToInt32(task.Result[i, j] % 7 == 0);
                    }
                }

                Console.WriteLine($"Количество элементов кратных 7: {count}");
            });

            generalTask.Start();
            generalTask.Wait();

            Console.ReadKey();

        }
    }
}