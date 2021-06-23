namespace OOP2
{
    public class Swan : Bird
    {
        public bool IsBlack { get; private set; }
        public Swan(string name, double weight, int age, bool hasFeathers, bool isBlack) : base(name, weight, age, hasFeathers)
        {
            IsBlack = isBlack;
        }

        
    }
}