namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation location;

        public Tower(MapLocation location)
        {
            this.location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (var invader in invaders)
            {
                if (invader.IsActive && location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }
        }
    }    
}
