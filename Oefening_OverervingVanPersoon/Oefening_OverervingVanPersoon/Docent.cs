using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_OverervingVanPersoon
{
    class Docent : Werknemer // klasse Docent is afgeleid van klasse Werknemer
    {
        private List<Module> _modules; //null

        public Docent(string naam, string bedrijf, decimal loon, DateTime geboorteDatum, Geslacht geslacht)
            : base(naam, bedrijf, loon, geboorteDatum, geslacht)//constructor van Werknemer aanroepen
        {
            _modules = new List<Module>(); //initialisatie van lege lijst;
        }
        public void VoegModuleToe(Module module)
        {
            _modules.Add(module);
        }
        public void VerwijderModule(Module module)
        {
            _modules.Remove(module);
        }
        public void PrintModules()
        {
            foreach (Module module in _modules)
            {
                Console.WriteLine($"\t->module:{module.Naam} lestijden: {module.Lestijden}");
            }
        }
    }
}
