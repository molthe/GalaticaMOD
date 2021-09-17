using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaticaMOD
{
    // the class Star inherits from SpaceObjects

    public class Star : SpaceObjects
    {
        // properties
        public string starName { get; set; }
        public float temperature { get; }
        public Startype startype { get; set; }
        public float positionX { get; set; }
        public float positionY { get; set; }

        // define what is in the star
        public Star(string starName, int x, int y, Startype startype, float temperature)
        {
            this.starName = starName;
            this.temperature = temperature;
            this.positionX = x;
            this.positionY = y;
            this.startype = startype;
        }
        // override so we can return the information
        public override string ToString()
        {
            return $"*** {starName} ***\nTemperature = {temperature}\nPositionX = {positionX}\n" +
                $"PositionY = {positionY}\nStartype = {startype}\n\n";
        }

        // list of Planets
        List<Planet> planetList = new List<Planet>();
    }
}
