using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_OverervingVanPersoon
{
    class Werknemer:Persoon //Werknemer is afgeleide klasse van Persoon
    {
        public string Bedrijf { get; set; }
        public decimal Loon { get; set; }

        public Werknemer(string naam, string bedrijf, decimal loon, DateTime geboorteDatum, Geslacht geslacht)
            :base(naam,geboorteDatum,geslacht) // base constructor aanroepen (deze van Persoon)
        {
            Bedrijf = bedrijf;
            Loon = loon;
        }
    }
}
