using System;

namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        private static Random random = new Random();

        public ShieldedInvader(Path path) : base(path)
        {}

        public override void DecreaseHealth(int factor) 
        {
            if (random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else 
            {
                Console.WriteLine("Missed. No Damage!");
            }
        }
    }
}