using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public abstract class RegularEmployee:Employee
    {
        public RegularEmployee(string firstName, string lastName, int age, double salary, Department department)
            :base(firstName,lastName,age,salary,department)
        {
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, age: {2}, salary: {3}, department: {4}",
                base.FirstName, base.LastName, base.Age, base.Salary, base.Department);
        }
    }
}
