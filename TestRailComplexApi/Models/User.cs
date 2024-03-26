﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRailComplexApi.Models.Enums;

namespace TestRailComplexApi.Models
{
    public  class User
    {
        public UserType UserType { get; set; }
        public string Username { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
    }
}
