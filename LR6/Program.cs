namespace LR6
{ 
    public class Program
    {
        public static void Main(string[] args) 
        {

            Series series = new Series();

            Console.WriteLine("Текущий список:");
            series.PrintAllPairs();


            series.pairs[0].Add(new Point2D(5, 7));
            series.pairs[1].Substract(new Point2D(5, 7));
            series.pairs[2].Add(new Point2D(1, 7));
            series.pairs[2].Add(new Cell('B', 7));

            Console.WriteLine("Изменённый список:");
            series.PrintAllPairs();

        }
    }
}
