using System;

namespace StringNaarIntDoubleDecimalVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geboortejaar?: ");
            string ingevoerdeGeboortejaar = Console.ReadLine();
            int geboorteJaar = int.Parse(ingevoerdeGeboortejaar);

            Console.Write("Lengte?: ");
            string lengteInvoer = Console.ReadLine();
            double lengte = double.Parse(lengteInvoer);


            Console.Write("Bedrag?: ");
            string bedragInvoer = Console.ReadLine();
            decimal bedrag = decimal.Parse(bedragInvoer);


            Console.WriteLine("Geboren in: " + geboorteJaar);
            Console.WriteLine("Lengte is: " + lengte);
            Console.WriteLine("Bedrag is: " + bedrag);

        }
    }
}
