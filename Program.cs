using System;

namespace GalaticaMOD
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Star sun = null;
            Console.WriteLine(sun);
            sun = new Star(0,0,SpaceObjects.Startype.RedGiant,5000);
            Console.WriteLine(sun);

            Star Betelgeuse = new Star(24, 25, SpaceObjects.Startype.YellowDwarf, 9223);
            Console.WriteLine(Betelgeuse);

        }
    }
}
