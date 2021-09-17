using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    abstract public class SpaceObjects
    {
        // declare and instantiante the enum Startype
        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

        // declare properties Id and Name
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type;

        // nested class position
        public class NestedPosition
        {
            public int x { get; set; }
            public int y { get; set; }

            // overrides Position and returns the values (x,y)
            public override string ToString()
            {
                return "(" + x + "," + y + ")";
            }
        }
    }
}

