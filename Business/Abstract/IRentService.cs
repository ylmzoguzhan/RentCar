﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentService
    {
        IDataResult<List<Rent>> GetAll();
        IResult Add(Rent rent);
        IDataResult<List<Rent>> GetAllByUserId(int id);
        IDataResult<List<RentDetailsDto>> GetRentsDetails();
        IDataResult<List<RentDetailsDto>> GetRentsDetailsByUserId(int userId);
    }
}
