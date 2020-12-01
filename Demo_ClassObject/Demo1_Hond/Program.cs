using System;
using System.Collections.Generic;

namespace Demo1_Hond
{
    class Hond
    {
        private string naam;//field
        private string ras; //field
        private string kleur;//field
        private int leeftijd;//field

        public void SetNaam(string roepnaam)
        {
            if (roepnaam == "")
            {
                Console.WriteLine("Ongeldige naam voor hond!");
                return;
            }
            naam = roepnaam;
        }
        public string GetNaam()
        {
            return this.naam;
        }
        public void SetRas(string ras)
        {
            this.ras = ras;
        }
        public string GetRas()
        {
            return this.ras;
        }
        //Gedrag of operatie van klasse Hond
        public void Spreek()
        {
            string naamHond = this.naam ?? "[Hond zonder naam]"; //Null coalescing operator ?? (als de waarde null is, geef een default waarde
            Console.WriteLine($"{naamHond} zegt: Woef!");
        }
    }
    class Program
    {
        static void Main()
        {
            Hond hond1 = new Hond(); //maak een nieuw object van klasse hond
            hond1.SetNaam("Bobby");
          //  hond1.SetRas("Collie");
            Hond hond2 = new Hond(); //maak nog een object van klasse hond
            hond2.SetNaam("Fifi");
            //hond2.SetRas("Golden Retriever");
            //hond2.SetNaam("");//Lukt niet -- naam validatie
            //Console.WriteLine($"Hond {hond1.GetNaam()} : ras: {hond1.GetRas()}");
            //Console.WriteLine($"Hond {hond2.GetNaam()} : ras: {hond2.GetRas()}");
            Hond hond3 = new Hond();
            List<Hond> honden = new List<Hond>();
            honden.Add(hond1);
            honden.Add(hond2);
            honden.Add(hond3);
            foreach (Hond hond in honden)
            {
                hond.Spreek();
            }
            //hond1.Spreek();
            //hond2.Spreek();
            //hond3.Spreek();
        }
    }
}
