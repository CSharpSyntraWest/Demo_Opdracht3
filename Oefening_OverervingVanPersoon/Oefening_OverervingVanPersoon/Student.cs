using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_OverervingVanPersoon
{
    class Student : Persoon// Student is afgeleide klasse van Persoon
    {
        public string Klas { get; set; }
        private List<Module> _ingeschrevenModules; //null

        public Student(string naam, string klas, DateTime geboorteDatum, Geslacht geslacht)
            : base(naam, geboorteDatum, geslacht)
        {
            Klas = klas;
            _ingeschrevenModules = new List<Module>(); //initialiseer een lege lijst van Module elementen
        }
        public void SchrijfInVoorModule(Module module)
        {
            _ingeschrevenModules.Add(module);
        }
        public void SchrijfUitVoorModule(Module module)
        {
            _ingeschrevenModules.Remove(module);
        }

        public void PrintModules()
        {
            foreach (Module module in _ingeschrevenModules)
            {
                Console.WriteLine($"\t->module:{module.Naam} lestijden: {module.Lestijden}");
            }
        }
    }
}
