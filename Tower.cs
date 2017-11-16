namespace TowerDefense
{
    class Tower
    {
        private const int range = 1;
        private const int power = 1;

        private readonly MapLocation location;

        public Tower(MapLocation location)
        {
            this.location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (var invader in invaders)
            {
                if (invader.IsActive && location.InRangeOf(invader.Location, range))
                {
                    invader.DecreaseHealth(power);
                    break;
                }
            }
        }
    }    
}
