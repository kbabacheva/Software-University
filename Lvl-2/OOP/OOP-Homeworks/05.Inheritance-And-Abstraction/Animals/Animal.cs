using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal:ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age,Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name 
        {
            get { return this.name;} 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Age 
        {
            get { return this.age; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Age cannot be zero or negative");
                }
                this.age = value;
            }
        }

        public Gender Gender 
        {
            get { return this.gender; }
            set { this.gender = value; } 
        }

        public abstract void ProduceSound();
    }
}
