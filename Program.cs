using System;
using System.ComponentModel.DataAnnotations;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person("Hello","There",1,125.5, 128.5);
            Console.WriteLine(person.ToString());
            person.Age = 5;
            Console.WriteLine("Age is now: " + person.ToString());
            Person person2 = new Person("Harry", "Potter");

            // CANNOT BE CREATED
            Person person3 = new Person("Hat", "Pot");
            try
            {
                Console.WriteLine("Enter a name: ");
                person3.FName = Console.ReadLine();
                //person3.FName = "Harry";
                Console.WriteLine(person3.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            

            person2.FName = "Lars";
            person2.Age = 25;

            int newAge = 28;

            PersonHandeler handler = new();

            handler.SetAge(person2, newAge);

        }
    }
}
