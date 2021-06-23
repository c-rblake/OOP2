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
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person(fname, lname, age, height, weight);

            return pers;
        }

        internal void SetFName(Person person, string v)
        {
            person.FName = v;
        }

        internal void SetLName(Person person, string v)
        {
            person.LName = v;
        }

        internal void SetHeight(Person person, double v)
        {
            person.Height = v;
        }

        internal void SetWeight(Person person, double v)
        {
            person.Weight = v;
        }
    }



}