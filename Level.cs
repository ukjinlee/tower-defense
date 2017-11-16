namespace TowerDefense
{
    class Level
    {
        private Invader[] invaders;
        
        public Tower[] towers { get; set; }

        public Level(Invader[] invaders)
        {
            this.invaders = invaders;
        }

        public bool Play()
        {
            int remainedInvaders = invaders.Length;

            while (remainedInvaders > 0)
            {
                foreach (var tower in towers)
                {
                    tower.FireOnInvaders(invaders);
                }

                remainedInvaders = 0;
                foreach (var invader in invaders)
                {
                    if (invader.HasScored)
                    {
                        return false;
                    }
                    if (invader.IsActive)
                    {
                        invader.Move();
                        remainedInvaders++;
                    }
                }
            }
            return true;
        }
    }
}