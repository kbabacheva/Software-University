using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_And_Worker
{
    class Program
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by faculty number in ascending order 
            List<Student> students = new List<Student>()
            {
            new Student("Katya","Dimitrova","as1234"),
            new Student("Marcel","Marceuo","1234567"),
            new Student("Ivan","Petrov","372645"),
            new Student("Petkan","Pavlov","003465"),
            new Student("Teddy","Grigirova","23dddde"),
            new Student("Zaza","Reno","237645"),
            new Student("Ico","Hristov","3645333"),
            new Student("Traycho","Ivanov","998765"),
            new Student("Misho","Topalovich","110293"),
            new Student("Slavi","Slavchec","3334232")
            };
           
            var ordered = from st in students
                          orderby st.FacultyNumber
                          select st;
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }

            //Initialize a list of 10 workers and sort them by payment per hour in descending order
            List<Worker> workers = new List<Worker>()
            {
            new Worker("Pesho", "Petrov",250,8),
            new Worker("Ivan", "Petrov",260,5),
            new Worker("Slavka", "Draganova",200,8),
            new Worker("Radka", "Chilingirova",350,8),
            new Worker("Zdravka", "Dragozova",250,10),
            new Worker("Penka", "Petrova",250,4),
            new Worker("Ivan", "Dimitrov",280,6),
            new Worker("Georgi", "Georgiev",270,7),
            new Worker("Dragan", "Petrovich",230,8),
            new Worker("Ivailo", "Ivanov",450,6),
            };

            //
            var paymentPerHourDescending = from w in workers
                                           orderby w.MoneyPerHour() descending
                                           select w;
            foreach (var item in paymentPerHourDescending)
            {
                Console.WriteLine(item.FirstName + " -> " + item.MoneyPerHour());
            }

            //Merge the lists and then sort them by first name and last name.
            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);
            var sortedPeople = from p in people
                               orderby p.FirstName,p.LastName
                               select p;
            foreach (var item in sortedPeople)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
