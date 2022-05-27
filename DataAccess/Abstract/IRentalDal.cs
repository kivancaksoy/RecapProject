using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
    }
}
