using System;

namespace OOP2
{
    public class Horse : Animal
    {
        private string run;
        public string Run { get; private set; }
        public Horse(string name, double weight, int age, string run) : base(name, weight, age)
        {
            Run = run;
            Console.WriteLine(run);
        }


        // public string Sound() => "Tut tut Greta!";
        public override string DoSound() 
        {
            return "GÄNGG!!!!";
        }

        
        
    }
}