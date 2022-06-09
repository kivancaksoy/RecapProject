using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(CarImage carImage, IFormFile file)
        {
            var result = BusinessRules.Run(CheckIfCarImagesLimitExceded(carImage.CarId));
            if (result != null)
            {
                return new ErrorResult();
            }
            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int carImage)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == carImage));
        }

        public IResult Update(CarImage carImage, IFormFile file)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath, PathConstants.ImagesPath);
            _carImageDal.Update(carImage);
            return new SuccessResult();

        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckIfCarImagePathNull(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
            }
            //return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId).Where(c => c.ImagePath != null).ToList());

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        private IResult CheckIfCarImagesLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count();
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImagePathNull(int carId)
        {
            //var result = _carImageDal.GetAll(c => c.CarId == carId).Any(c => c.ImagePath != null);
            //if (!result)
            //{
            //    return new ErrorResult();
            //}
            //return new SuccessResult();
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (!result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        //private IDataResult<List<CarImage>> GetDefaultImage (int carId)
        //{
        //    var results = _carImageDal.GetAll(c => c.CarId == carId).ToList();
        //    if (results.Count > 0)
        //    {
        //        foreach (var result in results)
        //        {
        //            result.ImagePath = "DefaultImage.jpg";
        //        }
        //        return new ErrorDataResult<List<CarImage>>(results);
        //    }
        //    return new SuccessDataResult<List<CarImage>>();
        //}

        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }

    }
}
