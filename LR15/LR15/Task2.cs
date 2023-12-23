using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15
{
    internal class Student
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
    }

    partial class Zadanie
    {
        public static void Task2()
        {
            List<List<Student>> groups = new List<List<Student>>() 
            {
                new List<Student> {
                    new Student { FirstName = "Иван", LastName = "Иванов" },
                    new Student { FirstName = "Петр", LastName = "Петров" },
                    new Student { FirstName = "Сергей", LastName = "Сидоров" },
                    new Student { FirstName = "Анна", LastName = "Смирнова" },
                    new Student { FirstName = "Елена", LastName = "Павлова" }
                },
                new List<Student> {
                    new Student { FirstName = "Дмитрий", LastName = "Козлов" },
                    new Student { FirstName = "Ольга", LastName = "Новикова" },
                    new Student { FirstName = "Михаил", LastName = "Морозов" },
                    new Student { FirstName = "Татьяна", LastName = "Волкова" },
                    new Student { FirstName = "Александр", LastName = "Алексеев" }
                },
                new List<Student> {
                    new Student { FirstName = "Евгений", LastName = "Лебедев" },
                    new Student { FirstName = "Мария", LastName = "Соколова" },
                    new Student { FirstName = "Валентин", LastName = "Петров" },
                    new Student { FirstName = "Юлия", LastName = "Иванова" },
                    new Student { FirstName = "Андрей", LastName = "Федоров" }
                },
                new List<Student> {
                    new Student { FirstName = "Наталья", LastName = "Максимова" },
                    new Student { FirstName = "Григорий", LastName = "Васильев" },
                    new Student { FirstName = "Вера", LastName = "Павлова" },
                    new Student { FirstName = "Степан", LastName = "Смирнов" },
                    new Student { FirstName = "Людмила", LastName = "Кузнецова" }
                },
                new List<Student> {
                    new Student { FirstName = "Игорь", LastName = "Орлов" },
                    new Student { FirstName = "Екатерина", LastName = "Николаева" },
                    new Student { FirstName = "Денис", LastName = "Комаров" },
                    new Student { FirstName = "Алевтина", LastName = "Григорьева" },
                    new Student { FirstName = "Роман", LastName = "Макаров" }
                }
            };


            Console.WriteLine("Студенты фамилии которых длиннее 6 символов:");
            groups.ForEach(group => group.Where(student => student.LastName.Length > 6).ToList().ForEach(student => Console.WriteLine(student.FirstName + " " + student.LastName)));
        }

    }
}
