using System;
using System.Text;

namespace OptioneleParameters
{
    class Program
    {
        static void Main()
        {
            HerhaalTekst("Hello", 5);
            HerhaalTekst("Hello"); //optionele parameter aantal zal 2 zijn
            HerhaalTekst(aantal: 10, tekst: "Hello");
            //HerhaalTekst("Hello", 10000);
        }

        private static void HerhaalTekst(string tekst, int aantal=2)
        {
            StringBuilder sb_LangeTekst = new StringBuilder();
            for (int i = 1; i <= aantal; i++)
            {
                sb_LangeTekst.Append(tekst);
            }
            Console.WriteLine(sb_LangeTekst);
        }
    }
}
