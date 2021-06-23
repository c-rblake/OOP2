namespace OOP2
{
    public abstract class Animal
    {
        // Protected Fields?
        public string Name { get; set; } 
        public double Weight { get; set; }
        public int Age { get; set; }
        public abstract string DoSound();

        public Animal(string name, double weight, int age)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;

        }

        //public Horse() : this("DefaultBrandName", 100, 256) { }

        //horse.DoSound()



    }
}
/*
I Övning 3.2 ber vi er skapa ett gränssnitt (interface) som heter Person. DET KOLLIDERAR MED PERSON.CS såkmlart.
    Om ni lägger det i samma projekt som ni gjorde Person-klassen 3.1 så kommer 
    ni få error för att de har samma namn. Döp då gränssnittet till något annat (typ IPerson) 
    så funkar det. Ett gränssnitt/interface kan alltså inte ha samma namn som en annan klass.
*/