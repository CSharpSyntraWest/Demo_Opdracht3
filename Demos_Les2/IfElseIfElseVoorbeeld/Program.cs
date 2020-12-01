using System;

namespace IfElseIfElseVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatuur?: ");
            int temperatuur = int.Parse(Console.ReadLine());
            if (temperatuur >= 30)
            {
                Console.WriteLine("het is erg warm");
            }
            else
            {
                if (temperatuur >= 15)
                {
                    Console.WriteLine("Het is aangenaam");
                }
                else
                {
                    if (temperatuur >= 5)
                    {
                        Console.WriteLine("Het is aan de frisse kant");
                    }
                    else
                    {
                        Console.WriteLine("Het koud");
                    }
                }
            }
        
    }
}
