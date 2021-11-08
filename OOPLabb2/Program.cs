using System;
using System.Collections.Generic;
namespace OOPLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion l1 = new Lion("Leo", 12, 173, "gyllene");
            
            Console.WriteLine(l1.AnimalFacts());

            Console.WriteLine("\n-----------------------------------------------------");

            Parrot p1 = new Parrot("Polly", 24, 1.3, "blå", true);
            
            Console.WriteLine(p1.AnimalFacts());

            Console.WriteLine("\n-----------------------------------------------------");
                                 
            PolarBear PB1 = new PolarBear("Isis", 14, 249);

            Console.WriteLine(PB1.AnimalFacts());

            Console.WriteLine("\n-----------------------------------------------------");

            BrownBear BB1 = new BrownBear("Nalle", 14, 250, true);

            Console.WriteLine(BB1.AnimalFacts());

            Console.WriteLine("\n-----------------------------------------------------");

            Console.WriteLine("{0} \n{1} \n{2} \n{3}", l1.MakeSound(), p1.MakeSound(), PB1.MakeSound(),BB1.MakeSound());

            Console.WriteLine("\n-----------------------------------------------------");

            List<Djur> allAnimals = new List<Djur>();    //Djuren kan också låta genom att först lägga dem i en lista,
                                                         //och sedan loopa igenom listan så att metoden MakeSound utförs
            allAnimals.Add(l1);                          //för var och en av dem.               
            allAnimals.Add(p1);
            allAnimals.Add(BB1);
            allAnimals.Add(PB1);

            foreach (Djur animal in allAnimals)
            {
                Console.WriteLine(animal.MakeSound());
            }
            
        }
    }
}
