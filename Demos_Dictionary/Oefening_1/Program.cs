using System;
using System.Collections.Generic;

namespace Oefening_1
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> woordenboek = new Dictionary<string, string>();
            woordenboek.Add("XML", "Extensible Markup Language");
            woordenboek.Add("C#", "Object Georiënteerde programmeertaal");
            woordenboek.Add("HTML", "Hypertext Markup Language");

            Console.WriteLine(woordenboek.ContainsKey("HTML"));
            Console.WriteLine(woordenboek.ContainsValue("Extensible Markup Language"));
            string waarde = woordenboek["C#"];
            Console.WriteLine("C#: " + waarde);
            foreach (KeyValuePair<string, string> keyvalue in woordenboek)
            {
                Console.WriteLine("{0,-10} -> {1}", keyvalue.Key, keyvalue.Value);
            }
        }
    }
}
