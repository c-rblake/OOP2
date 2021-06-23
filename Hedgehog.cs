namespace OOP2
{
    public class Hedgehog : Animal


    {
        private string move;
        public string Move { get; private set; }
        public Hedgehog(string name, double weight, int age, string move) : base(name, weight, age)
        {
            Move = move;
        }

        public override string DoSound()
        {
            return "SQUEEK";
        }
    }
}