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
    public class GearManager : IGearService
    {
        IGearDal _gearDal;
        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }
        public IDataResult<List<Gear>> GetAll()
        {
            return new SuccessDataResult<List<Gear>>(_gearDal.GetAll());
        }

        public IDataResult<Gear> GetByName(string name)
        {
            return new SuccessDataResult<Gear>(_gearDal.Get(g => g.Name == name));
        }
    }
}
