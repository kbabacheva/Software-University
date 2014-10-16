using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Class
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string details;

        public Class(List<Teacher> teachers, List<Student> students,string details = null)
        {
            this.Teachers = teachers;
            this.Students = students;
            this.Details = details;
        }
        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public string Details 
        {
            get { return this.details; }
            set { this.details = value; } 
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            string teachers = string.Join(", ", this.Teachers).ToString();
            string students = string.Join(", ", this.Students).ToString();
            strB.AppendFormat("Teachers: {0}, Students: {1} ", teachers, students);
            if (this.Details != null)
            {
                strB.AppendFormat(", Details: {0}", this.Details);
            }
            return strB.ToString();
        }
    }
}
