using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    sealed class Moon : Planet
    {
        // properties
        public string Orbiting { get; set; }
        public double DistanceToThePlanet { get; set; }

        // define what is in the moon
        public Moon() { }
        public Moon(Planet planet)
        {
            //Orbiting = planet;

            //// distanceToThePlanet does not work yet
            //// Distance calculates the distance to OrbitingPlanet using the parameters x1, x2, y1, y2, OrbitingPlanet
            //// x1, y1 is the Planet, x2, y2 is the coordinates for the OrbitingPlanet
            //public double Distance(double x1, double x2, double y1, double y2, string OrbitingPlanet)
            //   this.DistanceToThePlanet = Distance(x, y);

            //// Distance calculates the distance to the sun using the parameters x, y
            //// the sun has coordinates 0,0
            //double Distance(int x, int y)
            //{
            //    double newX = Convert.ToDouble(x) - 0, newY = Convert.ToDouble(y) - 0;
            //    double distance = Math.Sqrt(Math.Pow((newX), 2) + Math.Pow((newY), 2));
            //    return distance;
            //    }

            //}

            //// override so we can return the information
            //public override string ToString()
            //{
            //    return $"Orbiting = {planetName}";
        }
    }
}
