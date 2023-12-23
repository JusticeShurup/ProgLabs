using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15
{
    public class SportMan
    {
        public string Name { get; set; }

        public string CommandName { get; set; }

        public int Mark { get; set; }

        public override string ToString()
        {
            return $"ФИО: {Name} Название команды: {CommandName} Балл: {Mark}"; 
        }
    }

    partial class Zadanie
    {
        public static void Task3()
        {


            List<SportMan> sportsmenList = new();

            string[] names = { "Иван", "Петр", "Александр", "Дмитрий", "Сергей", "Михаил", "Николай", "Андрей", "Артём", "Владимир", "Антон", "Василий", "Григорий", "Даниил", "Егор" };
            string[] commandNames = { "Красные", "Синие", "Зеленые" };

            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                SportMan sportsman = new SportMan
                {
                    Name = names[i],
                    CommandName = commandNames[i % 3], // Равномерно распределяем спортсменов по командам
                    Mark = random.Next(1, 11) // Устанавливаем случайную оценку от 1 до 10
                };
                sportsmenList.Add(sportsman);
            }


            sportsmenList.GroupBy(sportman => sportman.CommandName).ToList()
                .ForEach(group => Console.WriteLine($"Количество баллов команды {group.First().CommandName}: {group.ToList().Sum(man => man.Mark)}"));
        }

    }
}

