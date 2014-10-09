using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main(string[] args)
    {
        Location mars = new Location(3.2,4.3,Planet.Mars);
        Console.WriteLine(mars);
    }
}
