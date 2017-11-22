namespace TowerDefense
{
    class Invader
    {
        private readonly Path path;
        private int pathStep = 0;
        
        public int Health { get; private set; } = 2;
        public MapLocation Location => path.GetLocationAt(pathStep);
        protected virtual int StepSize { get; } = 1;
        
        public bool HasScored => pathStep >= path.Length;
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            this.path = path;
        }

        public void Move() => pathStep += StepSize;
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!");
        }
    }    
}
