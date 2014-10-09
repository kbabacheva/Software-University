using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public enum Planet
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
    }

    public class Planets
    {
        public Planet planet;

        public Planets(Planet planet)
        {
            this.planet = planet;
        }

        public Planet Planet { get { return planet; } }
    }

