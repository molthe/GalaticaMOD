using System;
using System.Collections.Generic;

namespace GalaticaMOD
{
    class Program
    {
        static void Main(string[] args)
        {
            StarSun();

            List<Planet> planetList = PlanetList();
            //  List<Moon> moonList = MoonList();

            Console.WriteLine("Welcome to outer space....\n\n");
            Console.WriteLine("*** List of planets ***");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }

        private static void StarSun()
        {
            Star sun = new Star("Sun", 0, 0, SpaceObjects.Startype.RedGiant, 5000);
        }

        private static List<Planet> PlanetList()
        {
            // PLANETS
            //{planetName} {planetType} {positionX} {positionY}{DiameterInM} {RotationPeriodHours}  {RevolutionPeriodDays} 
            Planet mercury = new Planet("Mercury", SpaceObjects.PlanetType.Dwarf, 5, 5, 13131, 2, 300);
            Planet venus = new Planet("Venus", SpaceObjects.PlanetType.Gas_Giant, 15, 15, 13550, 16, 200);
            Planet earth = new Planet("Earth", SpaceObjects.PlanetType.Terrestial, 20, 20, 12742, 24, 365);
            Planet mars = new Planet("Mars", SpaceObjects.PlanetType.Terrestial, 25, 25, 12742, 26, 370);
            Planet jupiter = new Planet("Jupiter", SpaceObjects.PlanetType.Gas_Giant, 30, 30, 500, 300, 19365);
            Planet saturn = new Planet("Saturn", SpaceObjects.PlanetType.Gas_Giant, 35, 35, 900, 84, 1313);
            Planet uranus = new Planet("Uranus", SpaceObjects.PlanetType.Giant, 40, 40, 12313, 5524, 4365);
            Planet neptune = new Planet("Neptune", SpaceObjects.PlanetType.Giant, 9000, 3120, 12742, 24, 3613135);

            List<Planet> planetList = new List<Planet>();

            planetList.Add(mercury);
            planetList.Add(venus);
            planetList.Add(earth);
            planetList.Add(mars);
            planetList.Add(jupiter);
            planetList.Add(saturn);
            planetList.Add(uranus);
            planetList.Add(neptune);
            return planetList;
        }
        //// moons does not work yet
        //private static List<Moon> MoonList()
        //{        //// MOONS
        //    //// moons Luna, Titan, Phobos, Europe, Deimos, Ganymedes, Io, Mimas)
        //    Moon Luna = new Moon(planetName("earth)");
        //    //Moon Titan = new Moon("Neptune);


        //    List<Moon> moonList = new List<Moon>();
        //    moonList.Add(Luna);
        //    //   moonList.Add(Titan);
        //    return moonList;
        //}
    }
}
