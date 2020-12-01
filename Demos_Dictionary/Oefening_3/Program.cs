using System;
using System.Collections.Generic;

namespace Oefening_3
{
    class Program
    {
        static void Main()
        {
            string text = "een tekst,nog tekst,gewoon nog wat tekst";
            Dictionary<string, int> dict_woorden = new Dictionary<string, int>();
            string[] woorden = text.Split(' ', ',', '.');
            foreach (string woord in woorden)
            {               
                if (dict_woorden.ContainsKey(woord))
                   dict_woorden[woord]++;
                else
                    dict_woorden.Add(woord,1);
            }
            foreach (KeyValuePair<string, int> pair in dict_woorden)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
