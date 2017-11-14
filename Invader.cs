namespace TowerDefense
{
    class Invader
    {
        private readonly Path path;
        private int pathStep = 0;
        public MapLocation Location { get; private set; }

        public Invader(Path path)
        {
            this.path = path;
            Location = path.GetLocationAt(pathStep);
        }

        public void Move()
        {
            pathStep++;
            Location = path.GetLocationAt(pathStep);
        }
    }    
}
