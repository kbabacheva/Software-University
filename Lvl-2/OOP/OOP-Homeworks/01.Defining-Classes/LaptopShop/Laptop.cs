using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, decimal price, string manufacturer,string processor)
            : this(model, price, manufacturer)
        {
            this.Processor = processor;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor,string ram)
            : this(model, price, manufacturer,processor)
        {
            this.Ram = ram;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard)
            : this(model, price, manufacturer, processor,ram)
        {
            this.GraphicsCard = graphicsCard;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard, string hdd)
            : this(model, price, manufacturer, processor, ram, graphicsCard)
        {
            this.Hdd = hdd;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen)
            : this(model, price, manufacturer, processor, ram, graphicsCard,hdd)
        {
            this.Screen = screen;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery batteryType)
            : this(model, price, manufacturer, processor, ram, graphicsCard, hdd,screen)
        {
            this.Battery = battery;
        }

        public string Model 
        {
            get { return this.model; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price cannot be negatove or zero");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be empty");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor cannot be empty");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("RAM cannot be negatove or zero");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Graphics Card cannot be empty");
                }
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("HDD cannot be negatove or zero");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen cannot be empty");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine("Model: " + this.model);
            if(this.manufacturer != null)
            {
                strB.AppendLine("Manufacturer: " + this.manufacturer);
            }
            if (this.processor != null)
            {
                strB.AppendLine("Processor: " + this.processor);
            }
            if (this.ram != null)
            {
                strB.AppendLine("RAM: " + this.ram + " GB");
            }
            if (this.graphicsCard != null)
            {
                strB.AppendLine("Graphics Card: " + this.graphicsCard);
            }
            if (this.hdd != null)
            {
                strB.AppendLine("HDD: " + this.hdd + " GB");
            }
            if (this.screen != null)
            {
                strB.AppendLine("Screen: " + this.screen);
            }
            if (this.Battery != null)
            {
                strB.Append(this.Battery);
            }
            strB.AppendLine("Price: " + this.price + " lv.");
            return strB.ToString();
        }
    }
}
