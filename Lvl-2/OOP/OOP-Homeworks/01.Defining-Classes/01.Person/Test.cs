using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main()
    {
        Persons pesho = new Persons("Pesho", 22,"pesho@abv.bg");
        Console.WriteLine(pesho);
        Persons pepa = new Persons("Pepa",10);
        Console.WriteLine(pepa);
    }
}

