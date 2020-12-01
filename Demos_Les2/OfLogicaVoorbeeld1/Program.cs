using System;

namespace OfLogicaVoorbeeld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toegang: 1=kind 2=gepensioneerde 3=volwassene ?: ");
            string soortPersoon = Console.ReadLine();

            string toegangsPrijs;
            if (soortPersoon == "1" || soortPersoon == "kind")
            {
                toegangsPrijs = "De prijs is 10euro";
            }
            else if (soortPersoon == "2" || soortPersoon == "gepensioneerde")
            {
                toegangsPrijs = "De prijs is 20euro";
            }
            else if (soortPersoon == "3" || soortPersoon == "volwassene")
            {
                toegangsPrijs = "De prijs is 30euro";
            }
            else
            {
                toegangsPrijs = "Gelieve een correct keuze te maken uit de aangeboden opties.";
            }

            Console.WriteLine(toegangsPrijs);
        }
    }
}
