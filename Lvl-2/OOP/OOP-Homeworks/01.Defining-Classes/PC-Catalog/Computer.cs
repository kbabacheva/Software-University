using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    public class Computer
    {
        private string name;
        private IList<Components> components;

        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, IList<Components> components)
            :this(name)
        {
            this.Components = components;
        }

        public string Name
        { 
            get{return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public IList<Components> Components 
        { 
            get {return this.components;}
            set
            {
                if (null == value)
                {
                    throw new ArgumentException("Cannot be empty");
                }
                this.components=value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.Components.Sum(a => a.Price);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: {0}\n", this.Name);
            sb.AppendFormat("Price: {0}\n", this.Price);
            foreach (var component in this.Components)
            {
                sb.AppendLine(component.ToString());
            }
            return sb.ToString();
        }
    }
}
