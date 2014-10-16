using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class TomCat:Cat
    {
        public TomCat(string name, int age):base(name, age,Gender.male)
        {
        }

        public override string ToString()
        {
            return string.Format("I am a {0} cat, my name is {1} and I'm {2} years old", base.Gender, base.Name, base.Age);
        }
    }
}
