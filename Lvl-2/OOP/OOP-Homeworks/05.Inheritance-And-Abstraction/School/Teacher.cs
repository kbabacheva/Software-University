using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher:People
    {
        private List<Discipline> disciplines;
        private string details;

        public Teacher(string name, List<Discipline> disciplines, string details = null):base(name)
        {
            this.Disciplines = disciplines;
            this.Details = details;
        }
        public List<Discipline> Disciplines 
        {
            get { return this.disciplines; }
            set { this.disciplines = value; } 
        }

        public string Details 
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            string disciplines = string.Join(", ", this.Disciplines).ToString();
            strB.AppendFormat("Name: {0}, Disciplines:[ {1} ]", this.Name, disciplines);
            if (this.Details != null)
            {
                strB.AppendFormat(", Details: {0}", this.Details);
            }
            return strB.ToString();
        }
    }
}
