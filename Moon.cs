using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        // Distance calculates the distance to OrbitingPlanet using the parameters x1, x2, y1, y2, OrbitingPlanet
        // x1, y1 is the Planet, x2, y2 is the coordinates for the OrbitingPlanet
        public double Distance(double x1, double x2, double y1, double y2, string OrbitingPlanet)
        {
            double newX = x2 - x1, newY = y2 - y1;
            double distance = Math.Sqrt(Math.Pow(Convert.ToDouble(newX), 2) + Math.Pow(Convert.ToDouble(newY), 2));
            return distance;
        }
    }
}
