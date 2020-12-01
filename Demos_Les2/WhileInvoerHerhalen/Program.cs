using System;

namespace WhileInvoerHerhalen
{
    class Program
    {
        static void Main()
        {
            double afstandInMeter;
            Console.Write("Afstand in meter?: ");
            bool invoerOk=double.TryParse(Console.ReadLine(), out afstandInMeter);
            while (invoerOk == false)  // zelfde als !invoerOK
            {
                if (!invoerOk) Console.WriteLine("Gelieve een numeriek gegeven in te voeren!");
                Console.Write("Afstand in meter?: ");
                invoerOk = double.TryParse(Console.ReadLine(), out afstandInMeter);            
            } 

            Console.WriteLine($"In cm is dit: {afstandInMeter * 100}");
        }
    }
}
