using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Program
    {
        static void Main()
        {
            Laptop lenovo = new Laptop("lenovo G3", 1200, "Lenovo", "3.2GHZ", "8", "Intel HD Graphics 4400", "128", "14 inches",new Battery("lion"));
            Laptop acer = new Laptop("Acer Aspire",2000,"Acer","3.3 GHZ","12");
            Console.WriteLine(acer);
            Console.WriteLine(lenovo);
            
        }
    }
}
