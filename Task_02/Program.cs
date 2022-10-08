using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Используя динамические и анонимные типы данных, создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание. 
             */

            Dictionary<dynamic, dynamic> dictionary = new Dictionary<dynamic, dynamic>()
            {
                { new{ TKey = "white"},     new {TValue = "білий" } },
                { new{ TKey = "black"},     new {TValue = "чорний" } },
                { new{ TKey = "read"},      new {TValue = "читати" } },
                { new{ TKey = "write"},     new {TValue = "писати" } },
                { new{ TKey = "see"},       new {TValue = "бачити" } },
                { new{ TKey = "run"},       new {TValue = "бігти" } },
                { new{ TKey = "sit"},       new {TValue = "сидіти" } },
                { new{ TKey = "say"},       new {TValue = "казати" } },
                { new{ TKey = "in"},        new {TValue = "в" } },
                { new{ TKey = "under"},     new {TValue = "під" } }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key.TKey} -> {item.Value.TValue}");
            }

            Console.ReadLine();
        }
    }
}
