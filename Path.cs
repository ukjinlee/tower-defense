namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] path;

        public int Length => path.Length;

        public Path(MapLocation[] path)
        {
            this.path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < path.Length) ? path[pathStep] : null;
        }
    }    
}
