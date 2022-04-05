using Business.Abstract;
using Core.CrossCuttingConcerns.Secured;
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
            _carDal.Add(car);
            return new SuccessResult("Araç eklendi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            _securedTool.Secured("Admin");
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
    }
}
