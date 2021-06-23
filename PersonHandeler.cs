using System;

namespace OOP2
{
    public class PersonHandeler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
            Console.WriteLine("PersonHandeler: " + pers.ToString());
        }
    }
}