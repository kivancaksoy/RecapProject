using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            
            if (_rentalDal.IsThereAnyItem(r => r.CarId == rental.CarId))
            {

                if (_rentalDal.GetLastElement(r => r.CarId == rental.CarId, r2 => r2.Id).ReturnDate == null)
                {
                    return new ErrorResult(Messages.ReturnDateIsNull);
                }

            }

            rental.RentDate = DateTime.Now;
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.ReturnDateIsNotNull);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IResult Upddate(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
