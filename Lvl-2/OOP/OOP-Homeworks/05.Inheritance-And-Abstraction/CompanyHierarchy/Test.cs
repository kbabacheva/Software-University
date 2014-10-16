using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Sales> march = new List<Sales>()
            {
                new Sales("dress",new DateTime(2014,03,20),33.50),
                new Sales("hat",new DateTime(2014,03,21),15.50),
                new Sales("costume",new DateTime(2014,03,15),80),
                new Sales("furla bag",new DateTime(2014,03,23),300)
            };
            SalesEmployee ivan = new SalesEmployee("Pesho","Ivanov",22,400,Department.Sales,march);
          //  Console.WriteLine(ivan);

            List<Project> projects = new List<Project>()
            {
                new Project("Web site",new DateTime(2013,02,20),"Developing site for celling cars"),
                new Project("Game",new DateTime(2014,10,01),"Creating game snake"),
                new Project("Chess engine",new DateTime(2012,12,08),"Creating powerful 8-core chess engine")
            };

            Developer katrin = new Developer("Katya","Petrova",28,800,Department.Production,projects);
         //   Console.WriteLine(katrin);
            List<RegularEmployee> workers = new List<RegularEmployee> { ivan, katrin };
            Manager archi = new Manager("Archibal","Lector",1,2000,Department.Marketing,workers);
          //  Console.WriteLine(archi);
            Customer baiIvan = new Customer("Ivan","Hristov",60,33.50);
            Console.WriteLine(baiIvan);
        }
    }
}
