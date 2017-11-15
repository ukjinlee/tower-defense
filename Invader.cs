namespace TowerDefense
{
    class Invader
    {
        private readonly Path path;
        private int pathStep = 0;
        
        public int Health { get; private set; } = 2;

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

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }    
}
