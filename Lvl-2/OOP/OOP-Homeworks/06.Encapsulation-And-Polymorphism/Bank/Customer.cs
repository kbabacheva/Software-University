using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customer:ICustomer
    {
        private string name;
        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }
    }
}
