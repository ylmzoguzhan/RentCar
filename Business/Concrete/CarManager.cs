using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Secured;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        SecuredTool _securedTool;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            _securedTool = new SecuredTool();
        }
        public IResult Add(Car car)
        {
            _securedTool.Secured("Admin");
            ValidationTool.Validate(new CarValidator(),car);
            _carDal.Add(car);
            return new SuccessResult("Araç eklendi");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetListCarDetail());
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetailsByRent()
        {
            //_securedTool.Secured("Admin");
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetListCarDetailByRent());
        }

        public IDataResult<CarDetailsDto> GetCarDetailsByCarId(int id)
        {
            return new SuccessDataResult<CarDetailsDto>(_carDal.GetCarDetailCarId(id));
        }
    }
}
