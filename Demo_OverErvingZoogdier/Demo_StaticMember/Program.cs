using System;

namespace Demo_Polymorfisme_Kinderboerderij
{
    class Program
    {
        static void Main()
        {
            KinderBoerderij boederij = new KinderBoerderij("Vierkantshoeve Gijzenzele");
            boederij.VoegDierToe(new Dier() { Naam = "Beestje", Kleur = "zwart" });
            boederij.VoegDierToe(new Hond() { Naam = "Bobby", Ras = "Labrador" });
            boederij.VoegDierToe(new Kat() { Naam = "Minou", AantalMuizenPerDag = 2 });
            boederij.VoegDierToe(new Kip() { Naam = "Sofie", EierenPerDag = 2 });
            boederij.VoegDierToe(new Kip() { Naam = "Claire", EierenPerDag = 1 });

            Console.WriteLine("Aantal honden:" + Hond.Aantal);
            Console.WriteLine("Aantal katten:" + Kat.Aantal);
            Console.WriteLine("Aantal kippen:" + Kip.Aantal);
            // boederij.MaakBoerderijGeluiden();
        }

    }
}
