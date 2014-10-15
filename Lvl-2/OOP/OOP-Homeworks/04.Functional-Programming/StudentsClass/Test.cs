using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClass
{
    class Test
    {
        static void Main()
        {
            //Problem 3.	Class Student
            List<Student> students = new List<Student>()
            {
                new Student("Pesho","Ivanov",24,"123414","02221411","pesho@gmail.com",new List<int>(){3,4,5},2),
                new Student("Katya","Ivanova",26,"123056","+35928223322","ivanova@abv.bg",new List<int>(){6,4,5,3},2),
                new Student("Misho","Mihailov",29,"023456","088723311","misho@abv.bg",new List<int>(){2,2,5},1),
                new Student("Zdravka","Dimitrova",20,"199414","088223511","zdravcheto@gmail.com",new List<int>(){5,4,5},2),
                new Student("Ivan","Ivanovich",24,"188886","089223311","ivan@gmail.com",new List<int>(){3,6,5,4},1),
                new Student("Hristo","Petrov",27,"163466","+359 23273311","ico@abv.bg",new List<int>(){3,4,5,4},2),
                new Student("Maria","Ruseva",30,"128766","088243215","mara@gmail.com",new List<int>(){3,4,5,2,2,2},1)
            };

            students.ForEach(st => Console.WriteLine(st.ToString()+"\n"));

            //Problem 4.	Students by Group
            var group2 = from student in students
                                   where student.GroupNumber == 2
                                   orderby student.FirstName
                                   select student;
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Students from group 2");
            foreach (var item in group2)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

           // Problem 5.	Students by First and Last Name
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Students by first name and last name:");
            var alphabeticalOrder = from student in students
                                    where student.FirstName.CompareTo(student.LastName) < 0
                                    select student.FirstName + " " + student.LastName;
            foreach (var item in alphabeticalOrder)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 6.	Students by Age
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Students with age between 18 and 24");
            var between18and24 = from student in students
                                 where student.Age >= 18 && student.Age <= 24
                                 select student.FirstName + " " + student.LastName + ", age: " + student.Age;
            foreach (var item in between18and24)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 7.	Sort Students
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Sorted students with Lambda:");
            //with lambda expression
            var sortedStudentsLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            foreach (var item in sortedStudentsLambda)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            //with LINQ
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Sorted students with LINQ:");
            var sortedStudentsLINQ = from student in students
                                     orderby student.FirstName descending, student.LastName descending
                                     select student;
            foreach (var item in sortedStudentsLINQ)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            //Problem 8.	Filter Students by Email Domain
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Students with @abv.bg domain:");
            var abvDomain = from student in students
                            where student.Email.Contains("@abv.bg")
                            select student.FirstName + " " + student.LastName + ", email: " + student.Email;
            foreach (var item in abvDomain)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 9.	Filter Students by Phone
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Students with phones in Sofia:");
            var phones = from student in students
                         where student.PhoneNumber.StartsWith("02") || student.PhoneNumber.StartsWith("+3592") || student.PhoneNumber.StartsWith("+359 2")
                         select student.FirstName + " " + student.LastName + ", phone: " + student.PhoneNumber;
            foreach (var item in phones)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 10.	Excellent Students
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Excellent Students:");

            var excelentStudents = from student in students
                                   where student.Marks.Contains(6)
                                   select student.FirstName + " ,marks: " + string.Join(", ", student.Marks as IEnumerable<int>);
            foreach (var item in excelentStudents)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 11.	Weak Students
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Weak Students:");

            var weakStudent = students.Where(st => st.Marks.Where(mark => mark == 2).Count() == 2).Select(st => st.FirstName + " " + st.LastName + ", Marks: " + string.Join(", ", st.Marks as IEnumerable<int>));
            foreach (var item in weakStudent)
            {
                Console.WriteLine(item.ToString());
            }

            //Problem 12.	Students Enrolled in 2014
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Weak Students:");
            var students2014 = from student in students
                               where student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'
                               select student.FirstName + ", Faculty number: " + student.FacultyNumber;
            foreach (var item in students2014)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
