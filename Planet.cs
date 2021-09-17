using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    // The class inherits SpaceObjects
    public class Planet : SpaceObjects
    {
        // properties for diameter, rotation period, revolutionperiod
        public string planetName { get; set; }
        public PlanetType planetType { get; set; }
        public float positionX { get; set; }
        public float positionY { get; set; }
        public float DiameterInM { get; set; }
        public float RotationPeriodHours { get; set; }
        public float RevolutionPeriodDays { get; set; }
        public double DistanceToTheSun { get; set; }

        // define what is in the planet
        public Planet() { }
        public Planet(string planetName, PlanetType planetType, int x, int y, float DiameterInM, float RotationPeriodHours, float RevolutionPeriodDays)
        {
            this.planetName = planetName;
            this.planetType = planetType;
            this.positionX = x;
            this.positionY = y;
            this.DiameterInM = DiameterInM;
            this.RotationPeriodHours = RotationPeriodHours;
            this.RevolutionPeriodDays = RevolutionPeriodDays;
            this.DistanceToTheSun = Distance(x, y);

            // Distance calculates the distance to the sun using the parameters x, y
            // the sun has coordinates 0,0
            double Distance(int x, int y)
            {
                double newX = Convert.ToDouble(x) - 0, newY = Convert.ToDouble(y) - 0;
                double distance = Math.Sqrt(Math.Pow((newX), 2) + Math.Pow((newY), 2));
                return distance;
            }
        }
        // override so we can return the information
        public override string ToString()
        {
            // return name, type, distance to the sun, moons
            return $"Name: {planetName} \n" +
                $"Planettype: {planetType}\n" +
                $"Distance to the sun: {DistanceToTheSun:N2}\n\n";
        }

        // list of moon
        List<string> MoonList = new List<string>();
    }
}
