using System;
using System.Collections.Generic;

namespace Oefening_AbstracteKlasseDier
{
    abstract class Dier
    { 
        public string Kleur { get; set; }
        public abstract void Spreek();
        
        public override string ToString() // ToString is een virtuele methode van klasse Object
        {
            return "Kleur:" +  this.Kleur;
        }
    }
    abstract class Zoogdier : Dier
    { 
        public int AantalWekenDrachtig { get; set; }
        public abstract override void Spreek();
    }
    class Hond : Zoogdier
    { 
       public string Ras { get; set; }
        public override void Spreek()
        {
            Console.WriteLine("Woef");
        }
    }
    class Kat : Zoogdier
    {
        public int AantalMuizenPerDag { get; set; }
        public override void Spreek()
        {
            Console.WriteLine("Miaauuuw");
        }
    }
    class Program
    {
        static void Main()
        {
            // Dier dier = new Dier(); //Kan niet abstracte klasse
            Hond hond = new Hond() { Kleur = "Zwart", Ras = "Labrador" };
            Kat kat = new Kat() { Kleur = "Wit", AantalMuizenPerDag = 2 };
            List<Dier> dieren = new List<Dier>();
            dieren.Add(hond);
            dieren.Add(kat);

            foreach (Dier dier in dieren)
            {
                dier.Spreek();
            }
          //  hond.Spreek();
            //kat.Spreek();
        }
    }
}
