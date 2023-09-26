using System.IO.Enumeration;
using System.Text;

namespace LR5
{
    public class Worker : IHuman
    {
        public string _fullName {get; private set;}
        public int _year {get; private set;} // Год принятия на работу
        public string _post {get; private set;}
        public int _salary {get; private set;}
        public int _workExperience {get; private set;}


        public Worker() {}
        public Worker(string fullName, int year, string post, int salary, int workExperience)
        {
            _fullName = fullName;
            _year = year;
            _post = post;
            _salary = salary;
            _workExperience = workExperience;
        }

        public void ReadFromFile(ref StreamReader stream)
        {
            try
            {
                string[] info = stream.ReadLine().Split(" ");
                _fullName = info[0] + " "  + info[1] + " " + info[2];
                _year = int.Parse(info[3]);
                _post = info[4];
                _salary = int.Parse(info[5]);
                _workExperience = int.Parse(info[6]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        public void WriteInFile(ref StreamWriter streamWriter)
        {
            streamWriter.WriteLine(_fullName + " " + _year + " " + _post + " " + _salary + " " + _workExperience);

        }

        public override string ToString()
        {
            return _fullName + " " + _year + " " + _post + " " + _salary + " " + _workExperience;
        }
    }
}