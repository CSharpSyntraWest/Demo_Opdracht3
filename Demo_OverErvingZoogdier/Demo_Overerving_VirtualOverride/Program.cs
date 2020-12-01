using System;

namespace Demo_Overerving_VirtualOverride
{
    class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get;  set; }
        public virtual void Spreek()
        {
            Console.WriteLine("Dier zegt: joepie ik ben een dier ...");
        }
        public override string ToString()
        {
            return "Naam: " + Naam + "; Leeftijd: " + Leeftijd;

        }
    }
    class Zoogdier : Dier
    {
        public int AantalMaandenDrachtig { get; set; }
        public override void Spreek()
        {
            base.Spreek();
            Console.WriteLine("hallo ik ben een zoogdier ...");
        }
        public override string ToString()
        {
            return base.ToString() + "\nAantalMaandenDrachtig: " + AantalMaandenDrachtig;

        }
    }
    class Hond : Zoogdier
    {
        public string Ras { get; set; }
        public override void Spreek()
        {
            base.Spreek();
            Console.WriteLine("Woef!");
        }
        public override string ToString()
        {
            return base.ToString() + "\nRas: " + Ras;

        }
    }

    class Program
    {
        static void Main()
        {
            //Dier dier = new Dier();
            //dier.Spreek();
            //Zoogdier zoogdier = new Zoogdier();
            //zoogdier.Spreek();
            Hond hond = new Hond();
            hond.Naam = "Fifi";
            hond.Leeftijd = 3;
            hond.Ras = "Labrador";
            Console.WriteLine(hond.ToString());
           // hond.Spreek();
        }
    }
}
