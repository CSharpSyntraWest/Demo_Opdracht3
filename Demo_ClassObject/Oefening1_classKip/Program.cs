using System;
using System.Collections.Generic;

namespace Oefening1_classKip
{
    public class Kip
    {
        //fields toevoegen (naam en eierenPerDag)
        private string naam;
        private int eierenPerDag;
        //Maak een parameterloze constructor die het aantalEierenPerDag initialiseert op 1 
        //Maak een constructor met 2 parameters om de naam en het aantal eierenPerDag te initialiseren
        public Kip()//constuctors hebben geen return type
        {
            eierenPerDag = 1;
        }
        public Kip(string naam, int eierenPerDag)//constuctors hebben geen return type
        {
            this.naam = naam;
            this.eierenPerDag = eierenPerDag;
        }
        //Methoden SetNaam(), GetNaam() SetEierenPerDag() en GetEierenPerDag()
        public void SetNaam(string naam)
        {
            this.naam = naam;
        }
        public string GetNaam()
        {
            return this.naam;
        }
        public void SetEierenPerDag(int aantalEieren)
        {
            this.eierenPerDag = aantalEieren;
        }
        public int GetEierenPerDag()
        {
            return this.eierenPerDag;
        }
        public void LegEieren()
        {
            string naamKip = this.naam ?? "[Kip zonder naam]";
            Console.WriteLine($"{naamKip} heeft {this.eierenPerDag} ei(eren) gelegd");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kip kip1 = new Kip();//aanroepen van parameterloze constructor
            kip1.LegEieren();
            Kip kip2 = new Kip("Claire", 2);
            kip2.LegEieren();
            //kip1.SetNaam("Louise");
            //kip1.SetEierenPerDag(2);
           // Kip kip2 = new Kip();
            //kip2.SetNaam("Sofie");
            //kip2.SetEierenPerDag(1);
            //Kip kip3 = new Kip();
            //kip3.SetEierenPerDag(0);
            //List<Kip> kippen = new List<Kip>();
            //kippen.Add(kip1);
            //kippen.Add(kip2);
            //kippen.Add(kip3);
            //int totaalAantalEierenPerDag = 0;
            //foreach (Kip kip in kippen)
            //{
            //    kip.LegEieren();
            //    totaalAantalEierenPerDag += kip.GetEierenPerDag();
            //}
            //Console.WriteLine("Totaal aantal eieren per dag van alle kippen: " + totaalAantalEierenPerDag);
        }
    }
}
