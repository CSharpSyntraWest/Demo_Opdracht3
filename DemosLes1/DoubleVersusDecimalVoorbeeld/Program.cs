using System;

namespace DoubleVersusDecimalVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            double bedrag1 = 17; //of 17d
            decimal bedrag2 = 17m;
            Console.WriteLine(bedrag1 / 3);
            Console.WriteLine(bedrag2 / 3);

        }
    }
}
