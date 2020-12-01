using System;

namespace MeerdereMethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = new DateTime(2020, 11, 11);

            Console.WriteLine(datum.ToShortDateString());
            
            Console.WriteLine("datum + 1 jaar=" + datum.AddYears(1).ToShortDateString()); //één jaar optellen bij de datum

            //int[] temperaturen = { 32, 10, 27, 21 };
            //Print("orginele lijst ", temperaturen);
            //Array.Sort(temperaturen);
            //Print("gesorteerde lijst", temperaturen);
        }

        static void Print(string label, int[] getallen)
        {
            Console.WriteLine(label);
            foreach (int getal in getallen)
                Console.Write(getal + " ");

            Console.WriteLine();

        }
    }
}
