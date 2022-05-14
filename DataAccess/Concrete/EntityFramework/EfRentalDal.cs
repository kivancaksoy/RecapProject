using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, BlueContext>, IRentalDal
    {
        public bool IsThereAnyItem(Expression<Func<Rental, bool>> filter)
        {
            using (BlueContext context = new BlueContext())
            {
                return context.Set<Rental>().Any(filter);
            }
        }

        public Rental GetLastElement(Expression<Func<Rental, bool>> filter, Expression<Func<Rental, int>> filter2)
        {
            using (BlueContext context = new BlueContext())
            {
                return context.Set<Rental>().Where(filter).OrderBy(filter2).Last();
            }
        }
    }
}
