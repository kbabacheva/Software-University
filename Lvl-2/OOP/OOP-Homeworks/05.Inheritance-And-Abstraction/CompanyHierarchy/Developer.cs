using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Developer:RegularEmployee
    {
        private List<Project> projects;

        public Developer(string firstName, string lastName, int age, double salary, Department department,List<Project> projects)
            : base(firstName, lastName, age, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects 
        {
            get { return this.projects; }
            set { this.projects = value; } 
        }

        public override string ToString()
        {
            string projects = string.Join(", ", this.Projects).ToString();
            return string.Format("Name: {0} {1}, age: {2}, salary: {3}, department: {4}, Projects:[ {5} ]",
                base.FirstName, base.LastName, base.Age, base.Salary, base.Department,projects);
        }
    }
}
