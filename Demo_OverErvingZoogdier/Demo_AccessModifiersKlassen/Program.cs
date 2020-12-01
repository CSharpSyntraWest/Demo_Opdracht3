using System;

namespace Demo_AccessModifiersKlassen
{
    class Dier
    {
        protected string Naam { get; set; } //protected: toegankelijk in eigen en afgeleide klassen
        private DateTime geboorteDatum { get; set; }//private: enkel toegankelijk binnen klasse Dier
        protected void Beweeg() //protected: kan enkel in eigen en afgeleide klassen aangeroepen worden
        {
            Console.WriteLine($"Dier {this.Naam} beweegt...");

        }
        public void Print()
        {
            Console.WriteLine($"Naam: {Naam}");
        }
    }
    class Zoogdier:Dier
    {
        public int AantalMaandenDrachtig { get; set; }

        public void Slaap()
        {
            //this.geboorteDatum //lukt niet, want private
            Console.WriteLine($"Zoogdier {this.Naam} slaapt...");//Kan Naam aanspreken want Zoogdier is afgeleide klasse

        }
    }
    class Hond : Zoogdier //Hond is afgeleide klasse van Zoogdier
    {
        public string Ras { get; set; }//uitbreiding; extra property Ras
        public Hond(string naam, string ras)
        {
            Naam = naam; //ok want Naam is protected in klasse Dier
            Ras = ras;
        }

        public void Kwispel()
        {
            Console.WriteLine("Hond " + base.Naam );
            base.Beweeg(); //ok Beweeg is protected method en Hond is afgeleide klasse van Dier
            Console.WriteLine(" kwispelt met zijn staart");
        }

    }
    class Program
    {
        static void Main()
        {
            Dier dier = new Dier();
            //dier.Naam = "onbekend";//lukt niet Program is geen afgeleide klasse van Dier
           // dier.Beweeg(); //nok, want Beweeg is protected
            Zoogdier zoogdier = new Zoogdier();
            zoogdier.Slaap();//ok public mehtode
           // zoogdier.Beweeg();//niet ok protected methode
            zoogdier.AantalMaandenDrachtig = 3;
            Console.WriteLine($"Zoogdier is {zoogdier.AantalMaandenDrachtig} maanden drachtig");
            Hond hond = new Hond("Bobby", "Labrador");
            // hond.Naam =//lukt niet Program is geen afgeleide klasse van Dier
            hond.Print();
            hond.Kwispel();//ok Kwipel is public method
        }
    }
}
