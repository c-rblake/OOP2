namespace OOP2
{
    internal class Flamingo : Bird
    {
        public bool EatCoconut { get; private set; }
        public Flamingo(string name, double weight, int age, bool hasFeathers, bool eatCocoNut) : base(name, weight, age, hasFeathers)
        {
            EatCoconut = eatCocoNut;
        }

        
    }
}