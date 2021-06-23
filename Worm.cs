namespace OOP2
{
    public class Worm : Animal

    {
        private bool isPosionous;
        public bool IsPosionous { get; private set; }
        public Worm(string name, double weight, int age, bool isPosionous) : base(name, weight, age)
        {
            IsPosionous = isPosionous;
        }


        public override string DoSound()
        {
            return "Hiya!";
        }
    }
}