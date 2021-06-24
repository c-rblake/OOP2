using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOP2
{
    public static class ListExtenstions
    {
        public static void AddMany<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
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
            //3.2.7, Array med Animals kanske
            var result = new StringBuilder();
            result.AppendLine(horse.DoSound());
            Console.WriteLine(result);

            
            Dog dog = new("Lassie", 50, 24, 8);
            Hedgehog hedgehog = new("Phil", 25, 5, "Waggle");
            Worm worm = new("Tjernobyl", 25, 38, true);
            Bird bird = new("Parrot", 12, 24, true);
            Wolf wolf = new("Fenrir",12,24,false);
            Pelican pelican = new("Seaborn", 12, 24, true, false);
            Flamingo flamingo = new("Pink", 12, 24, true, false);
            Swan swan = new("Dive", 12, 24, true, true);
            Wolfman wolfman = new Wolfman("Wolverine", 95, 130, true);
            //string cry = wolfman.Stats();
            //Console.WriteLine(cry);

            var animals = new List<Animal> { dog,  };
            animals.AddMany(hedgehog, worm, bird, wolf, pelican, flamingo, swan, wolfman);
            //3.2.8
            foreach (var animal in animals)
            {

                Console.WriteLine(animal.GetType().Name.ToString() + " " + animal.DoSound());
                Console.WriteLine(animal.Stats());
                
                //if (animal is IPerson)
                //   Person temp = (Person)animal;
                //   Console.WriteLine(animal.Talk());

                if (animal is Dog)
                    Console.WriteLine("I AM A DOG\n");
                    Console.WriteLine(dog.GetString());
          
            }

            TextInputError textInputError = new();
            NumericInputError numericInputError = new();

            // 3.4.9
            GremlinAteCpuError gremlinError = new();
            CakeInKeyBoardError cakeError = new();
            HotCoffeeInKeyBoardError coffeeError = new();

            List<UserError> userErros = new List<UserError>() // add to list ; below.
            {
                textInputError, numericInputError, gremlinError, cakeError, coffeeError
            };

            Console.WriteLine();
            foreach (var error in userErros)
            {
                Console.WriteLine(error.UEMessage());
            }


            



            //UserError userError = new();

            //3.3.16
            //Console.WriteLine(dog.GetString());
            //Console.WriteLine(animals.GetString());

            // F: 3.2.13 fåglar behöver ett nytt attribut - Bird.cs
            // F: 3.2.14 Alla djur - Animal.cs
            // F: 3.3.9 Häst i HundLista. Båda är Animal men häst är inte hund.
            // F: 3.3.13 VAD HÄNDER?? 
            /* Det går att göra overwrite men basklassen klarar olika typer med 
             ett GetType call. WolfMan är undantaget. 
            Den har också override och en annan return.
            */
            // F: 3.3.17 Dogs only. GetString är inte definierad i Animal 
            // F: 3.3.17 Animals är en lista och har ingen GetString metod. 
            //Animal

            // F 3.4.11 Varför Polymorphism - Slipper samma kod om och om igen
            // Det är också rätt händigt när man skriver, går lite fortare tillslut.
            //F 3.4.12 Hur är det bättre - Man låser in beteenden som man måste ha
            //Men man kan också lägga till egna. 
            // Det är bra om man jobbar med andra eller sig själv i framtiden.
            // Hur tänkte jag kring implmentation i Applikation X och Y.
            //F 3.4.13 abstract class vs interface
            //Interface har ALDRIG implmentering av kod. Den är som en ren placeholder 
            //för en ide.
            //Abstrakta klassen kan ha implmenteringar
            //Klasser ÄRVER nedåt max ett arv per steg, Interface ärver som de vill.






        }
    }
}
/*
I Övning 3.2 ber vi er skapa ett gränssnitt (interface) som heter Person. DET KOLLIDERAR MED PERSON.CS såkmlart.
    Om ni lägger det i samma projekt som ni gjorde Person-klassen 3.1 så kommer 
    ni få error för att de har samma namn. Döp då gränssnittet till något annat (typ IPerson) 
    så funkar det. Ett gränssnitt/interface kan alltså inte ha samma namn som en annan klass.
*/