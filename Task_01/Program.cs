using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую коллекцию автомобилей 
             * со следующими данными: марка автомобиля, модель, год выпуска, цвет. 
             * А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона. 
             * Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного из автомобилей и полную характеристику приобретенной им модели.
             */

            List<Car> cars = new List<Car>()
            {
                new Car("Model S",  "Tesla",    2020, "White"),
                new Car("Vitara",   "Suzuki",   2019, "Red"),
                new Car("Veyron",   "Buggati",  2018, "Black"),
                new Car("X5",       "BMW",      2017, "Black"),
                new Car("QQ",       "Cherry",   2014, "Yellow"),
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer("Ivanov V.T.",     "Model S",  "+380943332265"),
                new Customer("Kimchuk S.T.",    "Model S",  "+380977774422"),
                new Customer("Hyuko S.S.",      "X5",       "+380931111234"),
                new Customer("Kotel R.P.",      "Vitara+",  "+380913532277"),
            };

            var query = from customer in customers
                        join car in cars
                            on customer.Model equals car.Model
                        select new
                        {
                            Name = customer.Name,
                            Phone = customer.Phone,
                            Model = customer.Model,
                            Brand = car.Brand,
                            Year = car.Year,
                            Colour = car.Colour,
                        };

            foreach(var item in query)
            {
                Console.WriteLine($"{item.Name} {item.Phone} {item.Model} {item.Brand} {item.Year} {item.Colour}");
            }

            Console.ReadLine();
        }
    }
}
