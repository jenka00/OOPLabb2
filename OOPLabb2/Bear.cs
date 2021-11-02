using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb2
{
    class Bear : Djur
    {        
        public Bear() : this("No data", 000, 000, "No data")
        {

        }
        public Bear(string name, int age, double weight, string colour)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = colour;
            NumberOfLegs = 4;
            Sound = "ROOOAAR";
            Food = " ";
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public override void Sleep()
        {
            Console.WriteLine("Schh. " + Name + " sover.");
        }

        public override string AnimalFacts()
        {
            return "Det här är en björn som heter " + Name + ". Dess ålder är " + Age + " år. \nDen har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".";
        }
    }

    class PolarBear : Bear
    {
        public PolarBear() : this("No data", 000, 000)
        {

        }
        public PolarBear(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = "vit";
            NumberOfLegs = 4;
            Sound = "VRAAAUUU";
            Food = "vikare";
        }

        public override string MakeSound()
        {
            return "Isbjörnen låter: " + Sound + "!!";
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public override void Sleep()
        {
            Console.WriteLine("Schh. " + Name + " sover.");
        }

        public override string AnimalFacts()
        {
            return "Det här är en isbjörn som heter " + Name + ". Dess ålder är " + Age + " år. \nDen har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".";
        }

        public void CheckWeight()
        {
            if (Weight < 300)
            {
                Console.WriteLine("Isbjörnen svälter. Den måste genast äta {0}.", Food);
            }
            else if (Weight > 300 && Weight < 500)
            {
                Console.WriteLine("Isbjörnen behöver snart äta fler {0}.", Food);
            }
            else
            {
                Console.WriteLine("Isbjörnen är mätt.");
            }
        }
    }
    class BrownBear : Bear
    {
        bool BornInCaptivity = false;

        public BrownBear() : this("No data", 000, 000, false)
        {

        }
        public BrownBear(string name, int age, double weight, bool bornInCaptivity)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Colour = "brun";
            BornInCaptivity = bornInCaptivity;
            NumberOfLegs = 4;
            Sound = "BRUM BRUM";
            Food = "bär";
        }

        public override string MakeSound()
        {
            return "Brunbjörnen låter: " + Sound + "!!";
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " äter " + Food + ".");
        }

        public override void Sleep()
        {
            Console.WriteLine("Schh. " + Name + " sover.");
        }

        public override string AnimalFacts()
        {
            return "Det här är en brunbjörn som heter " + Name + ". Dess ålder är " + Age + " år. \nDen har " + NumberOfLegs + " ben. " +
                "Färgen är " + Colour + ". Vikten är " + Weight + " kg. Huvudsaklig föda är " + Food + ".";
        }

        public void Hibernates()
        {
            DateTime dateToday = DateTime.Now;
            
            DateTime dateToHibernate = DateTime.Parse("2021 - 11 - 15");           
            
            TimeSpan daysUntilHibernat = dateToHibernate - dateToday;
            
            int daysLeft = Convert.ToInt32(daysUntilHibernat.TotalDays);
                     
            if(0 < daysLeft)
            {
                Console.WriteLine("{0} dagar kvar tills björnen går i ide.", daysLeft);
            }
            else
            {
                Console.WriteLine("Björnen sover i sitt lugna bo.");
            }
            
        }
    }

}
