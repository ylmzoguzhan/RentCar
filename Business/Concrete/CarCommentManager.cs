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
    public class CarCommentManager : ICarCommentService
    {
        ICarCommentDal _carCommentDal;
        public CarCommentManager(ICarCommentDal carCommentDal)
        {
            _carCommentDal = carCommentDal;
        }
        public IResult Add(CarComment carComment)
        {
            _carCommentDal.Add(carComment);
            return new SuccessResult("Araç eklendi");
        }

        public IDataResult<List<CarComment>> GetAll()
        {
            return new SuccessDataResult<List<CarComment>>(_carCommentDal.GetAll());
        }
    }
}
