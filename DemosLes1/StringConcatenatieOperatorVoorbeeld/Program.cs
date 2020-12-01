using System;

namespace StringConcatenatieOperatorVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            string mr = "Michel";
            string openvld = "De Croo";
            int ambt = 1;

            Console.WriteLine(openvld + " was de opvolger van " + mr + " " + ambt);

            int regeerPeriode = 4;
            Console.WriteLine(mr + " regeerde tot in " + (2016 + regeerPeriode));
            //string interpolatie
            Console.WriteLine($"{openvld} was de opvolger van {mr} {ambt}");
            //met placeholders
            Console.WriteLine("{0} was de opvolger van {1} {2}", openvld, mr, ambt);

        }
    }
}
