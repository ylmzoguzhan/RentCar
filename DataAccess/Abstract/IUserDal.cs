﻿using Core.DataAccess;
using Core.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepositoryBase<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
