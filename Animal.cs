using System;
using System.Reflection;

using System.Text;

namespace OOP2 { 
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

        

        public virtual string Stats() //3.2.2
        {
        //var result = new StringBuilder();
        //PropertyInfo[] myPropertyInfo;
        //myPropertyInfo = this.GetType("System.Type").GetProperties();
        Type t = this.GetType();
        var result = new StringBuilder();
        string type = $"Type is: {t.Name}";
            result.AppendLine(type);
        PropertyInfo[] props = t.GetProperties();
        result.AppendLine($"Properties (N = { props.Length})");
        foreach (var prop in props)
            if (prop.GetIndexParameters().Length == 0)
                    result.AppendLine($"   {prop.Name} ({prop.PropertyType.Name}): {prop.GetValue(this)}");
                else
                    Console.WriteLine($"   {prop.Name} ({prop.PropertyType.Name}): <Indexed>"
                                         );
            return result.ToString();

            

        }

        //public Horse() : this("DefaultBrandName", 100, 256) { }
        //horse.DoSound() Inte alls så enkelt. 





    }
}
/*
I Övning 3.2 ber vi er skapa ett gränssnitt (interface) som heter Person. DET KOLLIDERAR MED PERSON.CS såkmlart.
    Om ni lägger det i samma projekt som ni gjorde Person-klassen 3.1 så kommer 
    ni få error för att de har samma namn. Döp då gränssnittet till något annat (typ IPerson) 
    så funkar det. Ett gränssnitt/interface kan alltså inte ha samma namn som en annan klass.
*/