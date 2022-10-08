using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic.
             */

            Calculator calculator = new Calculator();

            Console.Write("Введите первое число: ");
            Double.TryParse(Console.ReadLine(), out double num1);

            Console.Write("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int num2);

            Console.Write("Введите операцию (Add, Sub, Mul, Div): ");
            string operationType = Console.ReadLine();

            double result = 0;
            switch (operationType)
            {
                case "Add":
                    result = calculator.Add(num1, num2);
                    break;
                case "Sub":
                    result = calculator.Sub(num1, num2);
                    break;
                case "Mul":
                    result = calculator.Mul(num1, num2);
                    break;
                case "Div":
                    result = calculator.Div(num1, num2);
                    break;

                default:
                    Console.WriteLine("Операция отсутствует.");
                    break;
            }

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}
