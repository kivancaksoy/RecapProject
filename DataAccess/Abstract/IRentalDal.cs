using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        public bool IsThereAnyItem(Expression<Func<Rental, bool>> filter);
        public Rental GetLastElement(Expression<Func<Rental, bool>> filter, Expression<Func<Rental, int>> filter2);
    }
}
