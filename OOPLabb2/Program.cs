using System;

namespace OOPLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur d1 = new Djur("Lejon", 10, 150, "gyllene");
            Console.WriteLine(d1.MakeSound());
            Console.WriteLine(d1.Colour);
            d1.AnimalFacts();
            d1.Eat();

            Djur d2 = new Djur();
            Console.WriteLine(d2.Colour);

            Parrot p1 = new Parrot();
            Console.WriteLine(p1.MakeSound());
            Console.WriteLine(p1.AnimalFacts());

            Parrot p2 = new Parrot("Bea", 12, 2.5, "blå", true);
            Console.WriteLine(p2.MakeSound());

            Console.WriteLine(p2.AnimalFacts());

            Lion l1 = new Lion();
            Console.WriteLine(l1.MakeSound());
            Console.WriteLine(l1.AnimalFacts());

            PolarBear PB1 = new PolarBear();
            Console.WriteLine(PB1.Food);

        }
    }
}
