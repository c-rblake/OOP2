using System;
using System.Reflection;

using System.Text;



namespace OOP2
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool tracking) : base(name, weight, age, tracking)
        {
        }

        public void Talk()
        {
            System.Console.WriteLine("I like to HOOOOOWL!!");
        }

        //public override string Stats() //3.2.2
        //{
        //    //var result = new StringBuilder();
        //    //PropertyInfo[] myPropertyInfo;
        //    //myPropertyInfo = this.GetType("System.Type").GetProperties();
        //    Type t = this.GetType();
        //    Console.WriteLine("Type is: {0}", t.Name);
        //    PropertyInfo[] props = t.GetProperties();
        //    Console.WriteLine("Properties (N = {0}):",
        //                      props.Length);
        //    foreach (var prop in props)
        //        if (prop.GetIndexParameters().Length == 0)
        //            Console.WriteLine("   {0} ({1}): {2}", prop.Name,
        //                              prop.PropertyType.Name,
        //                              prop.GetValue(this));
        //        else
        //            Console.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
        //                              prop.PropertyType.Name);
        //    return "Hello WOrld";



        //}
    }
}