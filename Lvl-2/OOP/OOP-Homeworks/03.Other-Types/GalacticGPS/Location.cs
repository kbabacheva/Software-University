using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public struct Location
    {
        private double latitude { get; set; }
        private double longitude { get; set; }
        public Planet Planet { get; set; }

        public Location(double latitude, double longitude, Planet planet):this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude 
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        public double Longitude 
        {
            get { return this.longitude; }
            set { this.longitude = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",this.Latitude,this.Longitude,this.Planet);
        }
    }

