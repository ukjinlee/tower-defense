using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Point m = new MapLocation(4, 2);
            Console.WriteLine(m is Point);
            Console.WriteLine(m is MapLocation);

            Point p = new Point(5, 6);
            Console.WriteLine(p is Point);
            Console.WriteLine(p is MapLocation);
        }
    }    
}
