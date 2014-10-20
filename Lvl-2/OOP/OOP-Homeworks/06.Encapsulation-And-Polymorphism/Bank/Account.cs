using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account:IAccount,IDepositable
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public ICustomer Customer 
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be empty");
                }
                this.customer = value;
            }
        }

        public decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; } 
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            set { this.interestRate = value; } 
        }

        public virtual decimal CalculateInterest(double months)
        {
            return this.Balance * (1 + ((this.interestRate * (decimal)months) / 100));
        }

        public virtual void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
