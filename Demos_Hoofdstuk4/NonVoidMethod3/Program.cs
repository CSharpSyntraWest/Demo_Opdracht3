using System;

namespace NonVoidMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Geef een jaartal?: ");
                int jaar = int.Parse(Console.ReadLine());
                //DateTime datum = new DateTime(2020, 1, 1);
                //Console.WriteLine(DateTime.IsLeapYear(datum.Year));
                if (IsSchrikkelJaar(jaar))
                {
                    Console.WriteLine($"{jaar} is een schrikkeljaar");
                }
                else
                {
                    Console.WriteLine($"{jaar} is geen schrikkeljaar");
                }
            } while (true);

        }

        private static bool IsSchrikkelJaar(int jaartal)
        {
            return DateTime.IsLeapYear(jaartal);
          //  return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }
    }
}
