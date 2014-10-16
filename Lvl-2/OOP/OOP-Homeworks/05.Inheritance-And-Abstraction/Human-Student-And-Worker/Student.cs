using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_And_Worker
{
    public class Student:Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber):base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public string FacultyNumber 
        {
            get { return this.facultyNumber; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faulty number cannot be empty");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Faulty number: {2}", base.FirstName, base.LastName,this.FacultyNumber);
        }
    }
}
