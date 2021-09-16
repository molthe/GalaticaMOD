using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    abstract class SpaceObjects
    {
        // declare and instantiante the enum Startype
        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
        // declare properties Id and Name
        public int Id { get; set; }
        public string Name { get; set; }
        // nested class position
        class Position
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
