using System;

namespace Oneindigheid
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("Ik val in oneindige herhalingen");

            //} while (true);
            int jaar = 1990;
            do
            {
                Console.WriteLine(jaar);
                jaar = jaar + 1;
            } while (jaar <= 1999);

        }
    }
}
