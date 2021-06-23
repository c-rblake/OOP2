using System;
using System.ComponentModel.DataAnnotations;

namespace OOP2
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        public int Age {
            get { return age; }
            set { 
                if(value < 0)
                {
                    throw new ArgumentException("Invalid Age. Enter an inte greater than 0.");
                }      
                this.age = value; }
            
        }

        //[Required]
        //[MinLength(2, ErrorMessage ="Name cannot be less than 2")]
        //[MaxLength(10, ErrorMessage="Name cannot be greater than 10")]
        //public string FName {
        //    get { return fName; }

        //    set {
        //        if (value is not String)
        //        {
        //            throw new ArgumentException("Invalid FNAME. Enter a string greater than 2 less than 10.");
        //            // throw new ArgumentException(nameof(Height));
        //        }
        //        else
        //        {
        //            this.fName = value;
        //        }
        //    }      
        //}
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                int lenght = value.Length;
                if (lenght < 2 ^ lenght > 10)
                {
                    throw new ArgumentException("Invalid FNAME. Enter a string greater than 2 less than 10.");
                }
                else
                {
                    this.fName = value;
                }
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                int lenght = value.Length;
                if (lenght < 3 ^ lenght > 15)
                {
                    throw new ArgumentException("Invalid FNAME. Enter a string greater than 3 less than 15.");
                }
                else
                {
                    this.lName = value;
                }
            }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Height. Enter an int greater than 0.");
                }
                this.height = value;
            }

        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Height. Enter an int greater than 0.");
                }
                this.weight = value;
            }

        }

        public Person(string fName, string lName, int age = 0, double height=0, double weight=0)
        {
            this.Age = age;
            this.FName = fName;
            this.LName = lName;
            this.Height = height;
            this.Weight = weight;

        }
        public override string ToString()
        {
            return $"Name: {FName} LName: {LName}, Age {Age}";
        }
    }
}