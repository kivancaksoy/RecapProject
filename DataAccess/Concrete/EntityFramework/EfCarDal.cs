using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, BlueContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (BlueContext context = new BlueContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join c2 in context.Colors
                             on c.ColorId equals c2.ColorId
                             select new CarDetailDto { Id = c.Id, CarName = c.CarName, BrandName = b.BrandName, ColorName = c2.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
