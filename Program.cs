using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person(1,"Hello","There",125.5, 128.5);

            Console.WriteLine(person.ToString());
        }
    }
}
