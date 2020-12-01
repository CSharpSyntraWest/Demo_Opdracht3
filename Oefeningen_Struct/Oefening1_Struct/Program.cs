using System;

namespace Oefening1_Struct
{
    class Program
    {
        struct TweeDPunt
        {
            int X;//veld
            int Y;//veld
            public TweeDPunt(int x, int y) //constructor om X en Y te initialiseren met x en y
            {
                X = x;
                Y = y;
            }
            public void PrintTweeDPunt() //methode public (overal aanroepbaar)
            {
                Console.WriteLine($"Het punt is ({X},{Y})");
            }

        }
        static void Main(string[] args)
        {
            TweeDPunt punt1 = new TweeDPunt(1, 2);
            punt1.PrintTweeDPunt();
        }
    }
}
