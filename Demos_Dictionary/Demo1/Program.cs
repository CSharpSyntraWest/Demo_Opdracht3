using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> steden = new Dictionary<int, string>();
            steden.Add(1000, "Brussel");
            steden.Add(8500, "Kortrijk");
            steden.Add(8200, "Brugge");
            Console.WriteLine(steden.ContainsKey(8500));
            Console.WriteLine(steden.ContainsValue("Brugge"));
            Console.WriteLine(steden.GetValueOrDefault(8200));
            string stad;
            if (steden.TryGetValue(1000, out stad)) Console.WriteLine(stad);

            Console.WriteLine(steden[8500]); //indexer aan de hand van de sleutel
            foreach (int sleutel in steden.Keys)
            {
                Console.WriteLine("{0,-10} -> {1}", sleutel, steden[sleutel]);
            }

            foreach (string waarde in steden.Values)
            {
                Console.WriteLine(waarde);
            }
            foreach (KeyValuePair<int, string> keyvalue in steden)
            {

                Console.WriteLine(keyvalue.Key + " - > " + keyvalue.Value);
            }
        }
    }
}
