namespace OOP2
{
    internal class Wolf : Animal
    {
        private bool tracking;

        public bool Tracking { get; private set; }
        public Wolf(string name, double weight, int age, bool tracking) : base(name, weight, age)
        {
            this.Tracking = tracking;
        }

        

        public override string DoSound()
        {
            return "HOOOOWL";
        }
    }
}