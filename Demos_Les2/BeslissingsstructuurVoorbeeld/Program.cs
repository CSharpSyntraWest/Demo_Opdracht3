using System;

namespace BeslissingsstructuurVoorbeeld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());
            if (temperatuur <= 0)
            {
                Console.WriteLine("Bij deze temperatuur vriest het.");
                Console.WriteLine("Brrrr");
            }

            Console.Write("Dank u voor het ingeven van de temperatuur");
        }
    }
}
