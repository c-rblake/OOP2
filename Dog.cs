using System;

namespace OOP2
{
    internal class Dog : Animal
    {
        private int count;
        public int Count { get; private set; }
        public Dog(string name, double weight, int age, int count) : base(name, weight, age)
        {
            Count = count;
        }


        // public string Sound() => "Tut tut Greta!";
        public override string DoSound()
        {
            return "WOFF!!!!";
        }

        public string GetString()
        {
            return "This is a DOG only Method";
        }
    }
}