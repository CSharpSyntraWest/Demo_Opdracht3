using System;

namespace DoWhileInvoerHerhalen
{
    class Program
    {
        static void Main()
        {
            double afstandInMeter;
            bool invoerOk;
            do
            {
                Console.Write("Afstand in meter?: ");
                invoerOk = double.TryParse(Console.ReadLine(), out afstandInMeter);
                if (!invoerOk) Console.WriteLine("Gelieve een numeriek gegeven in te voeren!");
            } while (invoerOk==false); // zelfde als !invoerOK

            Console.WriteLine($"In cm is dit: {afstandInMeter * 100}");
        }
    }
}
