using System;

namespace TowerDefense
{
    class MapLocation: Point
    {
        public MapLocation(int x, int y, Map map): base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException($"{this} is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }
            Point that = obj as Point;
            return this.X == that.X && this.Y == that.Y;
        }
    }    
}
