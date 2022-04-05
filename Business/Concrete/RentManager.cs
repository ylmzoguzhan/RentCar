using Business.Abstract;
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
        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }
        public IResult Add(Rent rent)
        {
            _rentDal.Add(rent);
            return new SuccessResult("Kiralama eklendi");
        }

        public IDataResult<List<Rent>> GetAll()
        {
            return new SuccessDataResult<List<Rent>>(_rentDal.GetAll());
        }
    }
}
