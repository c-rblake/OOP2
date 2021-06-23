using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOP2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //IUI ui = new IUI();

            Person person = new Person("Hello","There",1,125.5, 128.5);
            Console.WriteLine(person.ToString());
            person.Age = 5;
            Console.WriteLine("Age is now: " + person.ToString());
            Person person2 = new Person("Harry", "Potter");

            // CANNOT BE CREATED
            Person person3 = new Person("Hat", "Pot");
            //try
            //{
            //    Console.WriteLine("Enter a name: ");
            //    person3.FName = Console.ReadLine();
            //    //person3.FName = "Harry";
            //    Console.WriteLine(person3.ToString());
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            

            person2.FName = "Lars";
            person2.Age = 25;
            person2.Height = 185;
            person2.Weight = 85;

            int newAge = 28;

            
            PersonHandeler handler = new(); // Nytt object

            handler.SetAge(person2, newAge);

            //PersonHandeler.CreatePerson(int, stirng, string, double, double) // Nya metoder

            Person handeler_pers = handler.CreatePerson(8, "Ghost", "Buster", 154, 122);

            Console.WriteLine(handeler_pers.ToString());

            //handler.SetFName(Person, string); // MAKE EVENT? 
            handler.SetLName(handeler_pers, "Åkesson");
            handler.SetHeight(handeler_pers, 180.4);
            handler.SetWeight(handeler_pers, 77.8);
            handler.SetFName(handeler_pers, "Åke");

            Console.WriteLine(handeler_pers.ToString());
            //handeler_pers.Age = -1;

            Horse horse = new Horse("Zorro", 800, 8, "Galopp");

            var result = new StringBuilder();
            result.AppendLine(horse.DoSound());
            Console.WriteLine(result);


            
        }
    }
}
/*
I Övning 3.2 ber vi er skapa ett gränssnitt (interface) som heter Person. DET KOLLIDERAR MED PERSON.CS såkmlart.
    Om ni lägger det i samma projekt som ni gjorde Person-klassen 3.1 så kommer 
    ni få error för att de har samma namn. Döp då gränssnittet till något annat (typ IPerson) 
    så funkar det. Ett gränssnitt/interface kan alltså inte ha samma namn som en annan klass.
*/