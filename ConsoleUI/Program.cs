using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Car car1 = new Car() { BrandId = 4, CarName = "PEUGEOT 301", ColorId = 2, DailyPrice = 250, ModelYear = 2018};

            //Car car1 = new Car() { BrandId = 1, CarName = "BMW 5.20", ColorId = 1, DailyPrice = 1500, ModelYear = 2018, Description = "Full kaskolu" };
            //Car car2 = new Car() { BrandId = 4, CarName = "PEUGEOT 301", ColorId = 2, DailyPrice = 250, ModelYear = 2018, Description = "Full kaskolu" };
            //carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Update(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " : " + car.CarName + " - " + car.ModelYear + " model" + " Günlük ücret : " + car.DailyPrice + " - " + car.Description);
            //}

            //carManager.Delete(car1);


            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
