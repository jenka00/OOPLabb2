using System;

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

        }
    }
}
