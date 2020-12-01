using System;

namespace BoolDatatypeVoorbeeld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());
            bool isWarm = (temperatuur > 0);
            if (!isWarm)
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
            }
            else
            {
                Console.WriteLine($"Gelukkig vriest het niet bij {temperatuur} graden.");
            }

            Console.Write("Dank je voor het invoeren van de ");
            //if (iswarm == true) Console.Write("warme ");
            if (isWarm) Console.Write("warme ");//doet het zelfde
            Console.WriteLine("temperatuur");
        }
    }
}
