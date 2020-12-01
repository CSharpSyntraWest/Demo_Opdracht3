using System;

namespace RekenkundigeOperatorenVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 12.3;
            Console.Write("Fahrenheit: ");
            Console.WriteLine(celcius * 1.8 + 32);
            int bedragInGeheleEuros = 17;
            Console.Write("Minimum bedrag in muntstukken: ");
            Console.WriteLine(bedragInGeheleEuros % 5);//modulo operator
            Console.Write("Aantal biljetten van vijf: ");
            Console.WriteLine(bedragInGeheleEuros / 5);//gehele deling door 5 (geen cijfers na komma)

            double preciesEuroBedrag = bedragInGeheleEuros;
            Console.Write("Helft van het bedrag: ");
            Console.WriteLine(preciesEuroBedrag / 2);//resultaat met cijfers na de komma

        }
    }
}
