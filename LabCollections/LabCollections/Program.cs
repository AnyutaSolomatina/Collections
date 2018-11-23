using System;
using System.Collections.Generic;
namespace LabCollections
{
    delegate bool Sravnenie(string s1, string s2);
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractCar> Cars = new List<AbstractCar>
            {
               new HondaCivic(),
               new RenaultLogan(),
               new LadaPriora()
            };
            Console.WriteLine("Марки атомобилей:");
            Console.WriteLine();
            Cars.Sort();
            foreach (AbstractCar cars in Cars)
            {
                Console.WriteLine(cars);
            }
            Console.WriteLine();
            Console.WriteLine("Введите марку автомобиля, информацию о котором вы хотели бы узнать:");
            string st = Console.ReadLine();
            bool flag = false;

            foreach (AbstractCar car in Cars)
            {
                string car1 = car.Model();
                Sravnenie sr = (s1, s2) => s1 == s2;
                if (sr(st, car1))
                {

                    {
                        flag = true;
                        Console.WriteLine(car.EngineCapacity());
                        Console.WriteLine(car.BodyType());
                        Console.WriteLine(car.CarDrive());
                    }
                }
            }
            if (flag == false)
                Console.WriteLine("Не верно введена марка");
            Console.ReadKey();
        }
    }
}
