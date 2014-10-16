using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student:People
    {
        private int uniqueClassNumber;
        private string details;

        public Student(string name, int uniqueClassNumber, string details = null):base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Details = details;
        }
        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Class number cannot be empty");
                }
                this.uniqueClassNumber = value;
            } 
        }

        public string Details 
        {
            get { return this.details; }
            set { this.details = value; } 
        }
        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendFormat("Name: {0}, Unique number: {1}", this.Name, this.UniqueClassNumber);
            if (this.Details != null)
            {
                strB.AppendFormat(", Details: {0}", this.Details);
            }
            return strB.ToString();
        }
    }
}
