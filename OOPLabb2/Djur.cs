using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb2
{
   class Djur
    {
        public string Name 
        { get; set; }

        public int Age 
        { get; set; }

        public int NumberOfLegs 
        { get; protected set; }

        public double Weight 
        { get; set; }

        public string Colour 
        { get; set; }

        public string Food
        { get; protected set; }

        public string Sound
        { get; protected set; }

        public Djur() : this("No data", 000, 000, "No data")
        {
            
        }

        public Djur(string name, int age, double weight, string colour)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = colour;
        }

        public virtual string MakeSound()
        {
            return "Djuren är tysta";
        }

        public virtual void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Schh. Djuret sover.");
        }

        public virtual string AnimalFacts()
        {
            return "Det här är ett djur som heter " + Name + ". Dess ålder är " + Age + " år. \nDet har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".";
        }
    }
}
