using Business.Abstract;
using Core.Utilities.Business;
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
    public class RentManager : IRentService
    {
        IRentDal _rentDal;
        ICarService _carService;
        public RentManager(IRentDal rentDal, ICarService carService)
        {
            _rentDal = rentDal;
            _carService = carService;
        }
        public IResult Add(Rent rent)
        {
            BusinessRules.Run(IsEmpty(rent.CarId));
            _rentDal.Add(rent);
            return new SuccessResult("Kiralama eklendi");
        }

        public IDataResult<List<Rent>> GetAll()
        {
            return new SuccessDataResult<List<Rent>>(_rentDal.GetAll());
        }
        private IResult IsEmpty(int id)
        {
            var result = _carService.GetById(id);
            if (result.Data.Rent)
            {
                return new ErrorResult("Araba kirada");
            }
            return new SuccessResult();
        }
    }
}
