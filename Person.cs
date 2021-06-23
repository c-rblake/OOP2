namespace OOP2
{
    internal class Person
    {
        private int Age;
        private string FName;
        private string LName;
        private double Height;
        private double Weight;

        public Person(int age, string fName, string lName, double height, double weight)
        {
            this.Age = age;
            this.FName = fName;
            this.LName = lName;
            this.Height = height;
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"Name: {FName} LName: {LName}";
        }
    }
}