namespace LR13
{

    public class MyThread
    {
        public int Row { get; private set; }
        public int Column { get; private set; }


        public MyThread(int row, int col) 
        { 
            Row = row;
            Column = col;
        }

        public void ThreadMain()
        {
            int[,] matrix1 = new int[Row, Column];
            int[,] matrix2 = new int[Row, Column];
        
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    matrix1[i, j] = new Random().Next(9);
                    matrix2[i, j] = new Random().Next(9);
                }
            }


            int[,] resultMatrix = new int[Row, Column];
            
            Console.Write("Результирующая матрица");
            for (int i = 0; i < Row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Column; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{resultMatrix[i, j]} ");
                
                }
            }


        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyThread(5, 5);

            var t3 = new Thread(obj.ThreadMain);
            t3.Start();

            t3.Join();
            
        }
    }
}