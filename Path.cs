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
            return (pathStep < path.Length) ? path[pathStep] : null;
        }
    }    
}
