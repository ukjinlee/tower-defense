using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                MapLocation location = new MapLocation(20, 20, map);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }    
}
