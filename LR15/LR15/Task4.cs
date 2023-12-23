using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LR15
{
    internal class StudentTask4
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Marks { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " Оценки: " + Marks[0] + " " + Marks[1] + " " + Marks[2] + " " + Marks[3] + " " + Marks[4];
        }
    }


    partial class Zadanie
    {
        public static void Task4()
        {
            List<StudentTask4> students = new();
            XDocument document = XDocument.Parse("\r\n<Students>\r\n  <Student>\r\n    <FirstName>Иван</FirstName>\r\n    <LastName>Иванов</LastName>\r\n    <Grades>\r\n      <Grade>2</Grade>\r\n      <Grade>3</Grade>\r\n      <Grade>3</Grade>\r\n      <Grade>4</Grade>\r\n      <Grade>5</Grade>\r\n    </Grades>\r\n  </Student>\r\n  <Student>\r\n    <FirstName>Петр</FirstName>\r\n    <LastName>Петров</LastName>\r\n    <Grades>\r\n      <Grade>5</Grade>\r\n      <Grade>5</Grade>\r\n      <Grade>5</Grade>\r\n      <Grade>5</Grade>\r\n      <Grade>5</Grade>\r\n    </Grades>\r\n  </Student>\r\n  <Student>\r\n    <FirstName>Александр</FirstName>\r\n    <LastName>Александров</LastName>\r\n    <Grades>\r\n      <Grade>2</Grade>\r\n      <Grade>2</Grade>\r\n      <Grade>3</Grade>\r\n      <Grade>2</Grade>\r\n      <Grade>3</Grade>\r\n    </Grades>\r\n  </Student>\r\n  <Student>\r\n    <FirstName>Дмитрий</FirstName>\r\n    <LastName>Дмитриев</LastName>\r\n    <Grades>\r\n      <Grade>2</Grade>\r\n      <Grade>4</Grade>\r\n      <Grade>5</Grade>\r\n      <Grade>3</Grade>\r\n      <Grade>2</Grade>\r\n    </Grades>\r\n  </Student>\r\n  <Student>\r\n    <FirstName>Сергей</FirstName>\r\n    <LastName>Сергеев</LastName>\r\n    <Grades>\r\n      <Grade>5</Grade>\r\n      <Grade>4</Grade>\r\n      <Grade>5</Grade>\r\n      <Grade>4</Grade>\r\n      <Grade>5</Grade>\r\n    </Grades>\r\n  </Student>\r\n</Students>\r\n");
            

      
            var query = from student in document.Descendants("Student") select student;

            foreach ( XElement element in query )
            {
                var student = new StudentTask4 { FirstName = element.Element("FirstName").Value, LastName = element.Element("LastName").Value, Marks = new int[0]};


                foreach(var mark in element.Element("Grades").Descendants("Grade"))
                {
                    student.Marks = student.Marks.Append(Convert.ToInt32(mark.Value)).ToArray();

                }

                students.Add(student);
            }
            Console.WriteLine("Информация о студенте под номером 1: ");
            Console.WriteLine(students[0].ToString());

            Console.WriteLine("Студенты с плохими оценками: ");
            students.Where(student => student.Marks.Average() <= 3).ToList().ForEach(Console.WriteLine);
        }

    }
}
