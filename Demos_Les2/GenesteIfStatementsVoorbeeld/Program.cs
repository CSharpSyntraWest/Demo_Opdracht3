using System;

namespace GenesteIfStatementsVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatuur?: ");

            int temperatuur;
            bool isGelukt = int.TryParse(Console.ReadLine(), out temperatuur);
            if (isGelukt) {
                if (temperatuur <= 0) {
                    Console.WriteLine("Bij deze temperatuur vriest het");
                }
                else {
                    Console.WriteLine($"Het vriest niet bij temperatuur van {temperatuur} graden");
                }
            }
            else {
                Console.Write("Gelieve een geheel getal in te geven");
            }
        }
    }
}
