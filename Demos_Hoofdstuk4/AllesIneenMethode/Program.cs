using System;

namespace AllesIneenMethode
{
    class Program
    {
        static void ResetConsoleColors()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void Main()
        {
            ResetConsoleColors();

            do
            {
                PrintMenu();
                string menuOptie = Console.ReadLine();
                while ((menuOptie != "1") && (menuOptie != "2"))
                {
                    //SetErrorConsoleColors();
                    //Console.WriteLine("Gelieve een bestaande menu-optie uit te kiezen!");
                    //Console.WriteLine();
                    //ResetConsoleColors();
                    PrintFoutMelding("Gelieve een bestaande menu-optie uit te kiezen!");
                    PrintMenu();
                    menuOptie = Console.ReadLine();

                }

                Console.Write("Om-te-zetten waarde?: ");
                double getal;
                while (!double.TryParse(Console.ReadLine(), out getal))
                {
                    //SetErrorConsoleColors();
                    //Console.WriteLine("Gelieve een getal in te voeren!");
                    //ResetConsoleColors();
                    //Console.WriteLine();    
                    PrintFoutMelding("Gelieve een getal in te voeren!");
                    Console.Write("Om-te-zetten waarde?: ");
                }

                if (menuOptie == "1") 
                    Console.WriteLine($"{getal} centimeter is {getal * 0.3937} inch.\n");
                else
                    Console.WriteLine($"{getal} inch is {getal * 2.54} centimeter.\n");

            } while (true);
        }

        private static void SetErrorConsoleColors()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void PrintFoutMelding(string melding)
        {
            SetErrorConsoleColors();
            Console.WriteLine(melding);
            Console.WriteLine();
            ResetConsoleColors();
        }
        static void PrintMenu()
        {
            Console.WriteLine("Omzetting:");
            Console.WriteLine("1) centimeter -> inch");
            Console.WriteLine("2) inch -> centimeter");
            Console.Write("Keuze (1/2)?: ");
        }
    }
}
