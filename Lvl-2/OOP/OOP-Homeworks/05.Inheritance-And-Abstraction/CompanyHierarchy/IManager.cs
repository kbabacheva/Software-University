﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    interface IManager
    {
        List<RegularEmployee> CommandedEmployees { get; set;}
    }
}