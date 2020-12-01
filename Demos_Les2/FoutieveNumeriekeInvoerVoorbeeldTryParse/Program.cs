using System;

namespace FoutieveNumeriekeInvoerVoorbeeldTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal?: ");
            string ingevoerdeWaarde = Console.ReadLine();
            int getal;
            bool invoerOk = int.TryParse(ingevoerdeWaarde, out getal);
            if (invoerOk)
            {
                Console.WriteLine("U heeft de waarde {0} ingevoerd", getal);
            }
            else 
            {
                Console.WriteLine("Gelieve een geheel getal in te voeren");
            }


        }
    }
}
