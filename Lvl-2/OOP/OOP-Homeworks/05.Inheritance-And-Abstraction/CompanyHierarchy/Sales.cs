using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Sales
    {
        private string productName;
        private DateTime date = DateTime.Today;
        private double price;

        public Sales(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName 
        {
            get { return this.productName; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be empty");
                }
                this.productName = value;
            }
        }

        public double Price 
        {
            get { return this.price; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price cannot be negative or zero");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Product name: {0}, date: {1}, price: {2}",
                this.ProductName, this.date, this.Price);
        }

    }
}
