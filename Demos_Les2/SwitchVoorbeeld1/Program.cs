using System;

namespace SwitchVoorbeeld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toegang: 1=kind 2=gepensioneerde 3=volwassene ?: ");
            string soortPersoon = Console.ReadLine();

            string toegangsPrijs;
            switch (soortPersoon)
            {
                case "1":
                case "kind":
                    toegangsPrijs = "De toegang bedraagt 10EUR.";
                    break;
                case "2":
                case "gepensioneerde":
                    toegangsPrijs = "De toegang bedraagt 20EUR.";
                    break;
                case "3":
                case "volwassene":
                    toegangsPrijs = "De toegang bedraagt 30EUR.";
                    break;
                default:
                    toegangsPrijs = "Gelieve een correct keuze te maken uit de aangeboden opties.";
                    break;
            }
            Console.WriteLine(toegangsPrijs);

        }
    }
}
