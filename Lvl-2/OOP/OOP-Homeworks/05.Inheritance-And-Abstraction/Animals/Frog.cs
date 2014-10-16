using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog:Animal
    {
        public Frog(string name, int age, Gender gender):base(name, age,gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwak kwak");
        }

        public override string ToString()
        {
            return string.Format("I am a {0} frog, my name is {1} and I'm {2} years old", base.Gender, base.Name, base.Age);
        }
    }
}
