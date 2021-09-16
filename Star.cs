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
        public Startype Temperature { get; set; }

        // list of Planets
        List<Planet> planetList = new List<Planet>();


        Star sun = new Star()
        {
            Id = 1,
            Name = "Sun",
            //    Type = Enum.GetName(typeof(Startype.White)),
            //               SpaceObjects.NestedPosition =   NestedPosition()
            //{
            //    Get = (0, 0);
            //    return Get();
            //}
            //Temperature = 5500)
        };

    }
}
