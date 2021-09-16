using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    // The class inherits SpaceObjects
    class Planet : SpaceObjects
    {
        // properties for diameter, rotation period, revolutionperiod
        public double DiameterInM { get; set; }
        public double RotationPeriodHours { get; set; }
        public double RevolutionPeriodDays { get; set; }
        // list of moon
        List<string> Moon = new List<string>();

        // Distance calculates the distance to Star using the parameters x1, x2, y1, y2
        // x1, y1 is the planetPosition, x2, y2 is the coordinates for the Star
        public double Distance(double x1, double x2, double y1, double y2)
        {
            double newX = x2 - x1, newY = y2 - y1;

            double distance = Math.Sqrt(Math.Pow(Convert.ToDouble(newX), 2) + Math.Pow(Convert.ToDouble(newY), 2));
            return distance;
        }
    }
}
