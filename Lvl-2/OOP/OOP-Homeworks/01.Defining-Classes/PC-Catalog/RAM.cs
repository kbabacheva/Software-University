﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    public class RAM : Components
    {
        public RAM(string name, decimal price, string details = null) :
            base(name, price, details)
        {
        }
    }
}