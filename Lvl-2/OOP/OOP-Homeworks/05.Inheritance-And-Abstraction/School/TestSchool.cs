using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestSchool
    {
        static void Main()
        {
            Student pesho = new Student("Pesho",2);
            Student katya = new Student("Katya",1);
            Student ivan = new Student("Ivan",3,"weak student");
            Student penka = new Student("Penka",4,"excellent");
            Student gosho = new Student("Gosho",5);
          //  Console.WriteLine(katya);
          //  Console.WriteLine(ivan);
            Discipline oop = new Discipline("OOP",2,new List<Student>(){pesho,katya},"Very important course");
            Discipline kpk = new Discipline("KPK", 1, new List<Student>() { ivan, penka, gosho });
            Discipline java = new Discipline("Java", 2, new List<Student>() { penka}, "Noone wants to attend this course...");
            Discipline unity = new Discipline("Unity", 2, new List<Student>() { katya,pesho,ivan,gosho},"Course about creating 2D and 3D games, much interesting, very attendable...");
           // Console.WriteLine(oop);
           // Console.WriteLine(kpk);
           // Console.WriteLine(unity);
            Teacher nakov = new Teacher("Nakov", new List<Discipline>() { oop,kpk},"Creator of Softuni");
            Teacher dimitrov = new Teacher("Dimitrov", new List<Discipline> { unity});
          //  Console.WriteLine(nakov);
          //  Console.WriteLine(dimitrov);

            Class may2014 = new Class(new List<Teacher>() { nakov, dimitrov }, new List<Student>() { katya,pesho},"First class of Softuni");
          //  Console.WriteLine(may2014);
            School softuni = new School(new List<Class> { may2014});
            Console.WriteLine(softuni);
        }
    }
}
