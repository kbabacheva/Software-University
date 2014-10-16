using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;
        private string details;

        public Discipline(string name, int numberOfLectures, List<Student> students, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;

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

        public int NumberOfLectures 
        {
            get { return this.numberOfLectures; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Number of lectures cannot be negative or zero");
                }
                this.numberOfLectures = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; } 
        }

        public string Details 
        {
            get { return this.details;}
            set { this.details = value; }
        }

        public override string ToString()
        {
            string students = string.Join(", ",this.Students).ToString();
            StringBuilder strB = new StringBuilder();
            strB.AppendFormat("Name: {0}, Number of lectures: {1}, Students:[ {2} ]", this.Name, this.NumberOfLectures,students);
            if (this.Details != null)
            {
                strB.AppendFormat(", Details: {0}", this.Details);
            }
            return strB.ToString();
        }
    }
}
