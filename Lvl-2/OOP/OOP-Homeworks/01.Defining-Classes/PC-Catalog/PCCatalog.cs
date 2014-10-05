using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace PC_Catalog
{
    public class PCCatalog
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");

            Components hdd = new HDD("1TB",200);
            Components motherBoard = new MotherBoard("ASUS", 300, "X99-A LGA 2011-v3 Intel X99 SATA 6Gb/s");
            Components ram = new RAM("12GB", 130);
            Components grCard = new GraphicsCard("XFX Black Edition", 340, "Double D R9-280A-TDBD Radeon R9 280 3GB 384-Bit GDDR5 PCI Express 3.0 HDCP");

            Computer comp = new Computer("Gaming PC", new List<Components>() { hdd, motherBoard, ram,grCard });
            Console.WriteLine(comp);
        }

    }
}
