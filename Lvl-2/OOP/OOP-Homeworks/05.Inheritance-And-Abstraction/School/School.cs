using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.Classes = classes;
        }
        public List<Class> Classes 
        {
            get { return this.classes; }
            set { this.classes = value; } 
        }
        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            string classes = string.Join(", ", this.Classes).ToString();
            strB.AppendFormat("Classes: {0}", classes);
            return strB.ToString();
        }
    }
}
