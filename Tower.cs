using System;

namespace TowerDefense
{
    class Tower
    {
        private const int range = 1;
        private const int power = 1;
        private const double accuracy = .75;

        private static readonly Random random = new Random();

        private readonly MapLocation location;

        public Tower(MapLocation location)
        {
            this.location = location;
        }

        private bool IsSuccessfulShot()
        {
            return random.NextDouble() < accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (var invader in invaders)
            {
                if (invader.IsActive && location.InRangeOf(invader.Location, range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(power);
                        Console.WriteLine("Shot at and hit an invader!");
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
