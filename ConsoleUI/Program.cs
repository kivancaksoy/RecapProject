using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car() { Id = 8, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 350, Description = "Volkswagen Golf" };
            Car car2 = new Car() { Id = 9, BrandId = 5, ColorId = 4, ModelYear = 2020, DailyPrice = 300, Description = "Fiat Egea" };

            //car1 update için car3 oluşturuldu.
            Car car3 = new Car() { Id = 8, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 325, Description = "Volkswagen Golf" };


            Console.WriteLine("\n----------GetAll-----------\n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " - " + car.Description + " - Daily Price : " + car.DailyPrice);
            }

            Console.WriteLine("\n-----------Add----------\n");

            carManager.Add(car1);
            carManager.Add(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " - " + car.Description + " - Daily Price : " + car.DailyPrice);
            }

            Console.WriteLine("\n-----------Update----------\n");

            carManager.Update(car3);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " - " + car.Description + " - Daily Price : " + car.DailyPrice);
            }

            Console.WriteLine("\n-----------Delete----------\n");

            carManager.Delete(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " - " + car.Description + " - Daily Price : " + car.DailyPrice);
            }

            Console.WriteLine("\n-----------GetById (BrandId) ----------\n");

            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine("Id : " + car.Id + " - " + car.Description + " - Daily Price : " + car.DailyPrice);
            }
        }
    }
}
