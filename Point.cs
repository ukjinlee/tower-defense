using System;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point p)
        {
            return DistanceTo(p.X, p.Y);
        }

        public override string ToString()
        {
            return X + "," + Y;
        }
    }    
}
