using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Customer:Person,ICustomer
    {
        private double moneySpent;

        public Customer(string firstName, string lastName, int age, double moneySpent)
            : base(firstName, lastName, age)
        {
            this.MoneySpent = moneySpent;
        }
        public double MoneySpent
        {
            get
            {
                return this.moneySpent;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("Spent money cannot have a negative value");
                }
                this.moneySpent = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, age: {2}, spent money: {3}",
                base.FirstName, base.LastName, base.Age, this.MoneySpent);
        }
    }
}
