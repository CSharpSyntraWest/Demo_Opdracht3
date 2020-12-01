using System;

namespace IntParseVoorbeeld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geboortejaar?: ");
            string ingevoerdeGeboortejaar = Console.ReadLine();
            //int geboorteJaar = int.Parse(ingevoerdeGeboortejaar);
            int geboorteJaar;
            bool isGelukt = int.TryParse(ingevoerdeGeboortejaar, out geboorteJaar);
            if (!isGelukt)
            {
                Console.WriteLine("Geef een geheel getal aub");
                return;
            }
            int leeftijd = DateTime.Today.Year - geboorteJaar;
            Console.WriteLine($"Dit jaar word je {leeftijd} jaar oud");
        }
    }
}
