using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TestAnimals
    {
        static void Main()
        {
            Dog sharo = new Dog("Sharo",3,Gender.male);
           // Console.WriteLine(sharo);
           // sharo.ProduceSound();
            TomCat tom = new TomCat("Tom",2);
            //Console.WriteLine(tom);
            Kitten lazy = new Kitten("Lazy",1);
            Frog lara = new Frog("Lara",5,Gender.female);
            Dog archibal = new Dog("Archibal the great",1,Gender.male);
            TomCat marcel = new TomCat("Marcel",3);
            List<Animal> animals = new List<Animal>()
            {
                sharo,
                tom,
                lazy,
                lara,
                archibal,
                marcel
            };

            var averageAge = from animal in animals
                             group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into g
                             select new { GroupName = g.Key, AverageAge = g.ToList().Average(an => an.Age) };

            foreach (var item in averageAge)
            {
                Console.WriteLine("{0} -> average age: {1}", item.GroupName.Name, item.AverageAge);
            }
        }
    }
}
