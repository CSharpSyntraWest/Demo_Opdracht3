using System;

namespace Demo_ParameterLozeDefaultConstructor
{
    class Artikel
    {
        private string _naam;
        private double _prijs;

        public Artikel(string naam, double prijs)//constructor met 2 parameters
        {
            _naam = naam;
            _prijs = prijs;
        }
        public void PrintGegevens()
        {
            Console.WriteLine($"Artikel {_naam} prijs: {_prijs}");
        }
    }
    class Program
    {
        static void Main()
        {
            Artikel artikel = new Artikel("Stofzuiger",56.45); //new Artikel();
            artikel.PrintGegevens();
        }
    }
}
