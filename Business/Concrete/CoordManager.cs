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
    public class CoordManager : ICoordService
    {
        ICoordDal _coordDal;
        public CoordManager(ICoordDal coordDal)
        {
            _coordDal = coordDal;
        }
        public IDataResult<List<Coord>> GetAllByCarId(int id)
        {
            return new SuccessDataResult<List<Coord>>(_coordDal.GetAll(c => c.CarId == id));
        }
    }
}
