using System;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random random = new Random();

        private readonly MapLocation location;

        public Tower(MapLocation location)
        {
            this.location = location;
        }

        private bool IsSuccessfulShot()
        {
            return random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (var invader in invaders)
            {
                if (invader.IsActive && location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized invader!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Shot at and missed an invader.");
                    }
                    break;
                }
            }
        }
    }    
}
