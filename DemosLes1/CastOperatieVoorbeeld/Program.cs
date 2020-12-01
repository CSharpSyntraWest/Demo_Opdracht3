using System;

namespace CastOperatieVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Aantal centimeters?: ");
            //double centimeters = double.Parse(Console.ReadLine());
            //double meters = centimeters / 100;

            //int geheleMeters = (int) meters;

            //Console.WriteLine($"aantal gehele meters:{geheleMeters}");

            int afstand = 123;
            Console.WriteLine($"Afstand: {afstand}");

            double halveAfstand = afstand; // double <- int (widening)
            halveAfstand = halveAfstand / 2;
            Console.WriteLine($"Helft van deze afstand: {halveAfstand}");

        }
    }
}
