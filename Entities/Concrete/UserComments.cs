﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserComments:IEntity
    {
        public int Id { get; set; }
        public int cUserId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
    }
}
