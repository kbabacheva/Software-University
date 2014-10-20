using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LoanAccount:Account,IAccount,IDepositable
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(double months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months > 3)
                {
                    return base.CalculateInterest(months - 3);
                }
                else
                {
                    return this.Balance;
                }
            }
            if (this.Customer is CompanyCustomer)
            {
                if (months > 2)
                {
                    return base.CalculateInterest(months - 2);
                }
                else
                {
                    return this.Balance;
                }
            }
            return base.CalculateInterest(months);
        }
    }
}
