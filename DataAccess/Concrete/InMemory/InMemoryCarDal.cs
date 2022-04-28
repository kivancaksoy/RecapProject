using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {  
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 1500, Description = "BMW 5.20" },
                new Car { Id = 2, BrandId = 4, ColorId = 2, ModelYear = 2018, DailyPrice = 250, Description = "peugeot 301" },
                new Car { Id = 3, BrandId = 3, ColorId = 2, ModelYear = 2020, DailyPrice = 500, Description = "Volkswagen Passat" },
                new Car { Id = 4, BrandId = 5, ColorId = 3, ModelYear = 2018, DailyPrice = 200, Description = "Fiat Linea" },
                new Car { Id = 5, BrandId = 2, ColorId = 2, ModelYear = 2022, DailyPrice = 2500, Description = "MERCEDES-BENZ GLB 200 AMG" },
                new Car { Id = 6, BrandId = 1, ColorId = 4, ModelYear = 2020, DailyPrice = 1450, Description = "BMW 2.16" },
                new Car { Id = 7, BrandId = 2, ColorId = 5, ModelYear = 2021, DailyPrice = 1750, Description = "MERCEDES-BENZ CLA 200 AMG" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
