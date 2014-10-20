using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount:Account,IAccount,IWithdrawable,IDepositable
    {

        public DepositAccount(ICustomer customer, decimal balance, decimal monthlyInterestRate)
            :base(customer,balance,monthlyInterestRate)
        {

        }
        public void Withdraw(decimal amout)
        {
            this.Balance -= amout;
        }

        public override decimal CalculateInterest(double months)
        {
            if (this.Balance < 1000 && this.Balance >=0)
            {
                return this.Balance;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
