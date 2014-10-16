using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class SalesEmployee:RegularEmployee,ISalesEmployee
    {
        private List<Sales> sales;

        public SalesEmployee(string firstName, string lastName, int age, double salary, Department department, List<Sales> sales)
            :base(firstName,lastName,age,salary,department)
        {
            this.Sales = sales;
        }
        public List<Sales> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            string sales = string.Join(", ",this.Sales).ToString();
            return string.Format("Name: {0} {1}, age: {2}, salary: {3}, department: {4}, Sales:[ {5} ]",
                base.FirstName, base.LastName, base.Age, base.Salary, base.Department, sales);
        }
    }
}
