using System;

namespace OefeningRadenGetal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("#################################");
            Console.WriteLine("# Raad een getal tussen 1 en 10 #");
            Console.WriteLine("#################################");
            Console.WriteLine();
            //Declaratie van de variabelen
            int willekeurig, getal;
            int aantalPogingen = 1;

            //Willekeurig getal genereren tussen 1 en 10
            Random random = new Random();
            willekeurig = random.Next(1, 11);

            //Getal vragen aan de gebruiker
            Console.Write("Raad het geheel getal: ");
            getal = int.Parse(Console.ReadLine());
            //controleren in een lus of het ingegeven getal gelijk is aan het willekeurig getal
            while (getal != willekeurig)
            {
                Console.WriteLine();
                if (getal < 1 || getal > 10)
                {
                    Console.Write("Geef een getal tussen 1 en 10 aub:");
                }
                else
                {
                    if (getal < willekeurig)
                    {
                        Console.Write("Raad hoger!: ");
                    }
                    else if (getal > willekeurig)
                    {
                        Console.Write("Raad lager!: ");
                    }
                    aantalPogingen++;
                }
                getal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("U heeft het getal geraden in {0} poging(en)", aantalPogingen);
        }
    }
}
