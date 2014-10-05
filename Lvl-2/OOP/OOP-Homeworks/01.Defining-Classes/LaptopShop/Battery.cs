using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    public class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType)
        {
            this.batteryType = batteryType;
        }

        public Battery(string batteryType, int batteryLife):this(batteryType)
        {
            this.BatteryLife = batteryLife;
        }

        public Battery()
        {

        }

        public string BatteryType 
        { 
            get { return this.batteryType; } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery type cannot be empty");
                }
                this.batteryType = value; } 
            }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("Battery life cannot be negative");
                }
                this.batteryLife = value; } 
        }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            if(this.batteryType!= null)
            {
                strBuild.AppendLine(batteryType);
            }
            if(this.batteryLife > 0)
            {
                strBuild.AppendLine(batteryLife + "hours");
            }
            return strBuild.ToString();
        }
    }
}
