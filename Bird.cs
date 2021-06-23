namespace OOP2
{
    public class Bird : Animal

    {
        private bool hasFeathers;
        public bool HasFeathers{ get; set; }
        public Bird(string name, double weight, int age, bool hasFeathers) : base(name, weight, age)
        {
            this.HasFeathers = hasFeathers;
        }

        public override string DoSound()
        {
            return "Squak, Shriiik";
        }
    }
}