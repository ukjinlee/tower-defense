namespace TowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return 0 <= point.X && point.X < Width 
                && 0 <= point.Y && point.Y < Height;
        }
    }    
}
