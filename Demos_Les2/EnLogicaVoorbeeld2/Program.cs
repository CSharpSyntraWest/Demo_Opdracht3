using System;

namespace EnLogicaVoorbeeld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());

            if (temperatuur < 30 && temperatuur >= 15)
            {
                Console.WriteLine("Het is aangenaam warm.");
            }

            //zelfde resultaat maar met geneste stuctuur
            if (temperatuur < 30)
            {
                if (temperatuur >= 15)
                {
                    Console.WriteLine("Het is aangenaam warm.");
                }
            }


        }
    }
}
