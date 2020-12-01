using System;

namespace ConditioneleOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal?: ");
            int getal = int.Parse(Console.ReadLine());

            string getalInfo = (getal % 2 == 0) ? "even" : "oneven";

            Console.Write($"getal {getal} is " + ((getal % 2 == 0) ? "even" : "oneven"));
        }
    }
}
