using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb2
{
    class Parrot : Djur
    {
        private bool AbleToTalk = true;

        public Parrot() : this("No data", 000, 000, "No data", false)
        {

        }

        public Parrot(string name, int age, double weight, string colour, bool ableToTalk)
        {
            Name = name;
            Age = age;            
            Weight = weight;
            Colour = colour;
            NumberOfLegs = 2;
            Food = "frön";
            Sound = name + " vill ha kex";
            AbleToTalk = ableToTalk;
        }

        public override string MakeSound()
        {
            if (AbleToTalk)
            {
                return "Papegojan pratar: " + Sound + "!!";
            }
            else
            {
                return "Papegojan kan inte prata";
            }
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public override void Sleep()
        {
            Console.WriteLine("Schh. " + Name + " sover.");
        }

        public void Fly()
        {
            Console.WriteLine("Papegojan flyger iväg.");
        }

        public override string AnimalFacts()
        {
            return "Det här är en papegoja som heter " + Name + ". Dess ålder är " + Age + " år. \nDen har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".";
        }

    }
}
