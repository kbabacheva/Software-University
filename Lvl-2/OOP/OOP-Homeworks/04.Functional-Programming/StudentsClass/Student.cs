using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClass
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phoneNumber;
        private string email;
        private IList<int> marks;
        private int groupNumber;


        public Student(string firstName, string lastName, int age, string facultyNumber, string phoneNumber, string email, IList<int> marks,int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            if (null == marks)
            {
                this.Marks = new List<int>();
            }
            else
            {
                this.Marks = marks;
            }
            this.GroupNumber = groupNumber;
        }
        public string FirstName 
        {
            get { return this.firstName; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Age cannot be negative or zero");
                }
                this.age = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number cannot be negative or zero");
                }
                this.facultyNumber = value;
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number cannot be negative or zero");
                }
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be empty");
                }
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set 
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Marks cannot be null!");
                }
                this.marks = value; 
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Group number cannot be negative or zero");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            string marks = string.Join(", ", this.Marks as IEnumerable<int>);
            return string.Format("First name: {0}, Last name: {1}, Age: {2}, Faculty number: {3}, Phone number: {4}, Email: {5}, Marks: {6}, Group Number: {7}",
            this.FirstName,this.LastName,this.Age,this.FacultyNumber,this.PhoneNumber,this.Email,marks,this.GroupNumber);
        }
    }
}
