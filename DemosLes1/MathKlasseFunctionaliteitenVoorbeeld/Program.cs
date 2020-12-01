using System;

namespace MathKlasseFunctionaliteitenVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Pow(2, 5));//2 tot de macht 5
            Console.WriteLine(Math.Sqrt(4));//vierkantswortel
            Console.WriteLine(Math.Round(45.69877455, 3));//getal afronden op 3 cijfers na komma
            Console.WriteLine(Math.Abs(-41.51));//absolute waarde
            Console.WriteLine(Math.Ceiling(41.23));//naar boven afronden
            Console.WriteLine(Math.Floor(41.99));//naar beneden afronden

            double zijdeVierkant = 12.3;
            Console.Write("Oppervlakte vierkant: ");
            Console.WriteLine("{0:F2}", Math.Pow(zijdeVierkant, 2));
            double lengteRechthoekZijde1 = 3.0;
            double lengteRechthoekZijde2 = 4.0;
            double kwadraatLengteRechthoekZijde1 = Math.Pow(lengteRechthoekZijde1, 2);
            double kwadraatLengteRechthoekZijde2 = Math.Pow(lengteRechthoekZijde2, 2);
            double somVanDeKwadraten = kwadraatLengteRechthoekZijde1 + kwadraatLengteRechthoekZijde2;
            Console.Write("Lengte schuine zijde: ");
            Console.WriteLine(Math.Sqrt(somVanDeKwadraten));


        }
    }
}
