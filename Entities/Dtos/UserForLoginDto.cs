﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserForLoginDto:IDto
    {
        public string Tc { get; set; }
        public string Password { get; set; }
    }
}
