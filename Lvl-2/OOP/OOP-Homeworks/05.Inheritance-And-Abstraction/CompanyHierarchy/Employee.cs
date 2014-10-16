using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class Employee:Person,IEmployee
    {
        private double salary;
        private Department department;

        public Employee(string firstName, string lastName, int age, double salary, Department department)
            :base(firstName,lastName,age)
        {
            this.Salary = salary;
            this.Department = department;
        }
        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Salary cannot be zero or negative");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, age: {2}, salary: {3}, department: {4}",
                base.FirstName, base.LastName, base.Age,this.Salary,this.Department);
        }
    }
}
