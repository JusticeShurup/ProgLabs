namespace LR5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            StreamReader stream = new("input.txt");
            List<Worker> workers = new();
            StreamWriter streamWriter = new("output.txt");
            while (!stream.EndOfStream)
            {
                workers.Add(new Worker());
                workers[workers.Count - 1].ReadFromFile(ref stream);
                Console.WriteLine(workers[workers.Count - 1].ToString());
            }
            stream.Close();

            workers = workers.OrderByDescending(x => x._workExperience).ToList();
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i]._salary < 60000)
                    workers[i].WriteInFile(ref streamWriter);
            }
            streamWriter.Close();
        }
    }
}