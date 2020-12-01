using System;

namespace GenesteStructuurPriemgetal
{
    class Program
    {
        static void Main()
        {
            do
            {
                int getal;
                Console.Write("Geef een geheel getal (min 2)?: ");
                bool invoerOk = int.TryParse(Console.ReadLine(), out getal);
                if (invoerOk && getal >= 2)
                {
                    //zoek of het een priemgetal is
                    bool deelbaarDoor = false;
                    int deler = 2;
                    while (!deelbaarDoor && deler < getal)
                    {
                        deelbaarDoor = (getal % deler == 0);
                        deler++;
                    }
                    if (deelbaarDoor)
                    {
                        Console.WriteLine($"{getal} is geen priemgetal.");
                    }
                    else
                    {
                        Console.WriteLine($"{getal} is een priemgetal.");
                    }
                }
                else
                {
                    Console.WriteLine("Dit is geen geheel getal (die minstens 2 is).");
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
