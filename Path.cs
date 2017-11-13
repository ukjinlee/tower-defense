namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] path;

        public Path(MapLocation[] path)
        {
            this.path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            if (pathStep >= path.Length)
            {
                return null;
            }
            return path[pathStep];
        }
    }    
}
