namespace TowerDefense
{
    class TowerDefenseException : System.Exception
    {
        public TowerDefenseException(string message) : base(message)
        {}
    }

    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException(string message) : base(message)
        {}
    }
}