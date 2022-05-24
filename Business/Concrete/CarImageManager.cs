using Business.Abstract;
using Core.Utilities.FileHelper;
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
    public class CarImageManager: ICarImageService
    {

        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }



        public IResult Add(int carId, IFormFile file)
        {

            CarImage carImage = new CarImage
            {
                CarId = carId,
                ImagePath = FileHelper.Upload(file),
                Date = DateTime.Now
            };

            _carImageDal.Add(carImage);
            return new SuccessResult("eklendi");
        }

        public IDataResult<List<CarImage>> getAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IResult Delete(int id)
        {
            var carImage = _carImageDal.Get(ci => ci.Id == id);
            if (carImage == null) return new ErrorResult("yok");

            FileHelper.Delete(carImage.ImagePath);

            _carImageDal.Delete(carImage);
            return new SuccessResult("silindi");
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == carId);

            return new SuccessDataResult<List<CarImage>>("getirildi",result);
        }

        public IResult Update(int id, IFormFile file)
        {
            var carImage = _carImageDal.Get(ci => ci.Id == id);
            if (carImage == null) return new ErrorResult("yok");

            carImage.ImagePath = FileHelper.Update(carImage.ImagePath, file);

            _carImageDal.Update(carImage);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult<CarImage> GetPathById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarId == id));
        }
    }
}
