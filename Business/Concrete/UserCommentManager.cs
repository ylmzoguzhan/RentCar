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
    public class UserCommentManager : IUserCommentService
    {
        IUserCommentDal _userCommentDal;
        public UserCommentManager(IUserCommentDal userCommentDal)
        {
            _userCommentDal=userCommentDal;
        }
        public IResult Add(UserComment userComment)
        {
            _userCommentDal.Add(userComment);
            return new SuccessResult("Yorum eklendi");
        }

        public IDataResult<List<UserComment>> GetAll()
        {
            return new SuccessDataResult<List<UserComment>>(_userCommentDal.GetAll());
        }
    }
}
