using System;

namespace DatatypeBepaaltToegelatenOperatiesVoorbeeld1
{
    class Program
    {
        static void Main()
        {
            int bedrag = 125;
            Console.WriteLine(bedrag*2);

            double kilometer = 12.3;
            Console.WriteLine(kilometer * 0.621371);  // 7,6428633 (mijl)

            string groet = "Hallo";
          // Console.Write(groet * "wereld");  // compilefout: Operator '*' cannot be applied to operands of type 'string' and 'string'


        }
    }
}
