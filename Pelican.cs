namespace OOP2
{
    public class Pelican : Bird
    {
        private bool isPink;
        public bool IsPink { get; private set; }

        public Pelican(string name, double weight, int age, bool hasFeathers, bool isPink) : base(name, weight, age, hasFeathers)
        {
            IsPink = isPink;
        }

        public override string DoSound()
        {
            return "Unique Pelican sound";
        }
    }
}