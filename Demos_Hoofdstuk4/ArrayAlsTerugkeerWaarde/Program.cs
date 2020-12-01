using System;

namespace ArrayAlsTerugkeerWaarde
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resultaatArray = MaakGetallenArray(5);
            PrintArray(resultaatArray);
        }
        static void PrintArray(int[] getallen)
        {
            foreach (int getal in getallen)
                Console.Write(getal + " ");
        }
        static  int[] MaakGetallenArray(int lengte)
        {
            int[] getallen = new int[lengte];
            Random rand = new Random();
            for (int i = 0; i < lengte; i++)
            {
                getallen[i] = rand.Next(1, 7);//random getal tussen 1 en 6 bv dobbelsteen
            }
            return getallen;
        }
    }
}
