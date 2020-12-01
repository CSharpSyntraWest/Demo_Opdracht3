using System;

namespace NonVoidMethode2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kg = 47;
            int lengteIncm = 158;
            double bmi = BodyMassIndex(kg, lengteIncm);
            Console.WriteLine("{0:F2}", bmi);

            Console.WriteLine(BodyMassIndex(kg, lengteIncm));
        }

        private static double BodyMassIndex(int kg, int lengteIncm)
        {
            double lengteInMeter = lengteIncm / 100.0;
            return kg / Math.Pow(lengteInMeter, 2);
        }
    }
}
