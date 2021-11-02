using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb2
{
    class Lion : Djur
    {
        private string Presence = "Afrika";

        public Lion() : this("No data", 000, 000, "No data")
        {

        }
        public Lion(string name, int age, double weight, string colour)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = colour;
            NumberOfLegs = 4;
            Food = "kött";
            Presence = "Afrika";
            Sound = "ROOOAAR";
        }

        public override string MakeSound()
        {
            return "Lejonet ryter: " + Sound + "!!";
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public override void Sleep()
        {
            Console.WriteLine("Schh. " + Name + " sover.");
        }

        public void Hunt()
        {
            Console.WriteLine("Lejonet är ute och jagar.");
        }

        public override string AnimalFacts()
        {
            return "Det här är ett lejon som heter " + Name + ". Dess ålder är " + Age + " år. \nDet har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".\nDet kommer från " + Presence + ".";
        }
    }
}
