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
            CarManagerTest();

            //BrandManagerTest();

            //ColorManagerTest();
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} - {1}", brand.BrandId, brand.BrandName);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color { ColorId = 1004, ColorName = "KIRMIZI" });
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("{0} - {1}", color.ColorId, color.ColorName);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Update(new Car { Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 500, CarName = "VOLKSWAGEN PASSAT" });
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


            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //Console.WriteLine(carManager.GetById(2).CarName);

            foreach(var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} : {2} - {3} - {4}", car.Id, car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
