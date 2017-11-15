namespace TowerDefense
{
    class Invader
    {
        private readonly Path path;
        private int pathStep = 0;
        
        public int Health { get; private set; } = 2;
        public MapLocation Location => path.GetLocationAt(pathStep);
        
        public bool HasScored => pathStep >= path.Length;
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            this.path = path;
        }

        public void Move() => pathStep++;
        public void DecreaseHealth(int factor) => Health -= factor;
    }    
}
