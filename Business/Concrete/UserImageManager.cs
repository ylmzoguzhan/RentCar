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
    public class UserImageManager : IUserImageService
    {
        IUserImageDal _userImageDal;
        public UserImageManager(IUserImageDal userImageDal)
        {
            _userImageDal = userImageDal;
        }
        public IResult Add(UserImage image)
        {
            _userImageDal.Add(image);
            return new SuccessResult();
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll());
        }

    }
}
