using System;

namespace MethodOverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'X';
            PrintHerHaald(letter);

            string tekst = "Stukje tekst";
            PrintHerHaald(tekst);

            PrintHerHaald(tekst, 3);

            PrintHerHaald(tekst,2);
        }

        private static void PrintHerHaald(string tekst, int aantal)
        {
            Console.WriteLine($"Eerste {aantal} letters van {tekst}: " + tekst.Substring(0, aantal));
        }

        private static void PrintHerHaald(char letter)
        {
            Console.WriteLine("Letter :" + letter);
        }
        static void PrintHerHaald(string input)
        {
            Console.WriteLine($"De tekst is: '{input}'");
        }

    }
}
