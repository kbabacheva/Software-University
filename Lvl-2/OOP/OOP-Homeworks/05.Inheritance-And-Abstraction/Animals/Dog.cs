using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, int age, Gender gender):base(name, age,gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Barkkkkk");
        }

        public override string ToString()
        {
            return string.Format("I am a {0} dog, my name is {1} and I'm {2} years old",base.Gender,base.Name,base.Age);
        }
    }
}
