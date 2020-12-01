using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_OverervingVanPersoon
{
    class Persoon
    {
        public string Naam { get; set; } //Auto-property
        public DateTime GeboorteDatum { get; set; } //Auto-property
        public Geslacht Geslacht { get; set; }//Auto-property

        public Persoon(string naam, DateTime geboorteDatum, Geslacht geslacht)//constructor
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }
    }
}
