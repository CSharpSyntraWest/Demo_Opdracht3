using System;

namespace ExclusieveOfVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            string kaart1 = "Ruiten acht";
            string kaart2 = "Schoppen heer";

            string troef = "Schoppen";
            bool kaart1IsTroefkaart = kaart1.StartsWith(troef);
            bool kaart2IsTroefkaart = kaart2.StartsWith(troef);

            //bool beginMetHello = "Hello World".StartsWith("Hello");//geeft true terug
            //bool eindigtMetWorld = "HelloWorld".EndsWith("World");//Geeft true terug
            //bool bevatHello = "blabalbalHellonogwatblblblala".Contains("Hello");//geeft true terug
            if (kaart1IsTroefkaart ^ kaart2IsTroefkaart)
            {
                string kaart = "";
                if (kaart1IsTroefkaart) kaart = kaart1; else kaart = kaart2;
                Console.Write($"{kaart} haalt de slag");
            }
            else
                Console.WriteLine("Vergelijk op waarde kaarten");

        }
    }
}
