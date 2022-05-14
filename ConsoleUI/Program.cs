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
            //RentalManagerTest();

            //CustomerManagerTest();

            //UserManagerTest();

            //CarManagerTest();

            //BrandManagerTest();

            //ColorManagerTest();
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { CarId = 1, CustomerId = 1 }).Message);
            //rentalManager.Delete(new Rental { Id = 5});
            //rentalManager.Upddate(new Rental { Id = 4, CarId = 1, CustomerId = 1, ReturnDate = new DateTime(2022, 05, 15)});
        }

        private static void CustomerManagerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId = 6, CompanyName = "GOOGLE" });
            customerManager.Update(new Customer { UserId = 4, CompanyName = "SONY"});
        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Halil", LastName = "Çınar", Email = "halil1@gmail.com", Password = "asdhalil3" });
            //userManager.Update(new User { Id = 1, FirstName = "Kıvanç", LastName = "Aksoy", Email = "test1@test.com", Password = "test123" });
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("{0} - {1}", brand.BrandId, brand.BrandName);
            }
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color { ColorId = 1004, ColorName = "KIRMIZI" });
            foreach (var color in colorManager.GetAll().Data)
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
            //carManager.Update(car1);
            //carManager.Delete(car1);

            foreach(var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} / {1} : {2} - {3} - {4}", car.Id, car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                
            }

            //Console.WriteLine(carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2022, DailyPrice = 2500, CarName = "MERCEDES-BENZ GLB 200 AMG", Description = "Yıllık kiralamaya uygundur." }).Message);

            var result = carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2022, DailyPrice = 0, CarName = "MERCEDES-BENZ GLB 200 AMG", Description = "Yıllık kiralamaya uygundur." });
            Console.WriteLine(result.Message);
        }
    }
}
