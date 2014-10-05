using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    public class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Components(string name, decimal price,string details)
            :this(name,price)
        {
            this.Details = details;
        }

        public string Name { 
            get{return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price cannot be negative or zero");
                }
                this.price= value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                this.details = value;
            }
        }

        public override string ToString()
        {
            string overRide = string.Format("Name : {0}\n",this.Name);
            overRide += string.Format("Price : {0:C}\n",this.Price);
            if (!string.IsNullOrEmpty(this.Details))
            {
                overRide += string.Format("Details : {0}\n",this.Details);
            }
            return overRide;
        }
    }
}
