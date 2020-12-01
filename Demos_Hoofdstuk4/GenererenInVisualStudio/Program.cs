using System;

namespace GenererenInVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] temperaturen = { 10, 21, 13, 17 };
            Console.Write($"({dagen.Length} elementen) ");
            PrintGetallen(dagen);
            //foreach (int dag in dagen)
            //{
            //    Console.Write(dag + " ");
            //}
            Console.WriteLine();
            Console.Write($"({temperaturen.Length} elementen) ");
            PrintGetallen(temperaturen);
            //foreach (int temperatuur in temperaturen)
            //{
            //    Console.Write(temperatuur + " ");
            //}
        }
        static void PrintGetallen(int[] getallen)
        {
            foreach (int getal in getallen)
            {
                Console.Write(getal + " ");
            }
        }
    }
}
