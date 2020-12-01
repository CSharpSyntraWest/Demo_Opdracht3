using System;

namespace Demo_Polymorfisme_Kinderboerderij
{
    class Program
    {
        static void Main()
        {
            /*Voeg een nieuw soort dier toe aan de kinderboerderij: Babe het varkentje 
             */
            KinderBoerderij boederij = new KinderBoerderij("Vierkantshoeve Gijzenzele");
            boederij.VoegDierToe(new Dier() { Naam = "Beestje", Kleur = "zwart" });
            boederij.VoegDierToe(new Hond() { Naam = "Bobby", Ras = "Labrador" });
            boederij.VoegDierToe(new Kat() { Naam = "Minou", AantalMuizenPerDag = 2 });
            boederij.VoegDierToe(new Kip() { Naam = "Sofie", EierenPerDag = 2 });
            boederij.VoegDierToe(new Kip() { Naam = "Claire", EierenPerDag = 1 });
           // boederij.VoegDierToe(new Varken() { Naam = "Babe" });
            boederij.MaakBoerderijGeluiden();
        }
    }
}
