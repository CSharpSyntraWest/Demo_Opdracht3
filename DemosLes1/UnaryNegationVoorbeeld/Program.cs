using System;

namespace UnaryNegationVoorbeeld
{
    class Program
    {
        static void Main(string[] args)
        {
            int doelpuntenVoor = 3;
            int doelpuntenTegen = 5;
            Console.Write("Doelpuntensaldo: ");
            Console.WriteLine(doelpuntenVoor + -doelpuntenTegen); // -2

        }
    }
}
