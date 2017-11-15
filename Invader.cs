namespace TowerDefense
{
    class Invader
    {
        private readonly Path path;
        private int pathStep = 0;
        
        public MapLocation Location 
        { 
            get
            {
                return path.GetLocationAt(pathStep);
            }
        }

        public Invader(Path path)
        {
            this.path = path;
        }

        public void Move()
        {
            pathStep++;
        }
    }    
}
