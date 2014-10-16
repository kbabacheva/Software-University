using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten:Cat
    {
        public Kitten(string name, int age):base(name, age,Gender.female)
        {
        }

        public override string ToString()
        {
            return string.Format("I am a {0} kitten, my name is {1} and I'm {2} years old", base.Gender, base.Name, base.Age);
        }
    }
}
