using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Manager:Employee,IManager
    {
        private List<RegularEmployee> commandedEmpoyees;

        public Manager(string firstName, string lastName, int age, double salary, Department department, List<RegularEmployee> commandedEmpoyees)
            : base(firstName, lastName, age, salary, department)
        {
            this.CommandedEmployees = commandedEmpoyees;
        }
        public List<RegularEmployee> CommandedEmployees
        {
            get
            {
                return this.commandedEmpoyees;
            }
            set
            {
                this.commandedEmpoyees = value;
            }
        }

        public override string ToString()
        {
            string commandedEmpoyees = string.Join(", ", this.CommandedEmployees).ToString();
            return string.Format("Name: {0} {1}, age: {2}, salary: {3}, department: {4}, Employees:[ {5} ]",
                base.FirstName, base.LastName, base.Age, base.Salary, base.Department, commandedEmpoyees);
        }
    }
}
