namespace LR12
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            
            List<NumberData> list = new List<NumberData>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new NumberData());
                list.LastOrDefault().Add(new Random().Next(100));
            }

            Console.ReadLine();
        }
    }
}