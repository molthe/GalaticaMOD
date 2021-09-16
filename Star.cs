using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    // the class Star inherits from SpaceObjects
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    public class Star : SpaceObjects
    {
        // property Temperature (for the enum StarType)
        public float temperature { get; }
        public Startype startype { get; set; }

        public float positionX { get; set; }
        public float positionY { get; set; }

        // list of Planets
        List<Planet> planetList = new List<Planet>();

        public Star() { }

        public Star(int x, int y, Startype startype, float temperature)
        {
            this.temperature = temperature;
            this.positionX = x;
            this.positionY = y;
            this.startype = startype;
        }

        public int metode()
        {
            return 7;
        }

        public override string ToString()
        {
            return $"Temperature = {temperature}, PositionX = {positionX}, PositionY = {positionY}, Startype is {startype}...";
        }
        //public class Position
        //{
        //    public int x { get; set; }
        //    public int y { get; set; }

        //    // overrides Position and returns the values (x,y)
        //    public override string ToString()
        //    {
        //        return "(" + x + "," + y + ")";
        //    }
        //}

    }
}
