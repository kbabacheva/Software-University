﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAccount
    {
        ICustomer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }
        decimal CalculateInterest(double months);
    }
}
