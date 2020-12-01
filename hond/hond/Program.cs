using System;
using System.Collections.Generic;

namespace hond
{

class Hond
    {
        private string naam;
        private string ras;
        private string kleur;
        private int leeftijd;
        //Default parameterloze constructor: 
        public Hond()
        {
            this.naam = "?";
            this.ras = "Onbekend";
            this.kleur = "?";
            this.leeftijd = 0;
        }
        public Hond(string naam, string ras)//constructor met 2 parameters
        {
            this.naam = naam;
            this.ras = ras;
        }
        public Hond(string naam, string ras, string kleur, int leeftijd)//constructor met 4 parameters
        {
            this.naam = naam;
            this.ras = ras;
            this.kleur = kleur;
            this.leeftijd = leeftijd;
        }
        public void SetNaam(string roepnaam)
        {
            if (roepnaam == "")
            {
                Console.WriteLine("Geen geldige roepnaam");
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
        public void Spreek()
        {
            string naamHond = this.naam ?? "[Hond zonder naam]";
            Console.WriteLine($"{naamHond} zegt Woef!");
        }
        public void PrintGegevens()
        {
            Console.WriteLine($"Hond : {this.GetNaam()}, Ras: {this.GetRas()}, Kleur: {this.kleur}, leeftijd: {this.leeftijd}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hond hond1 = new Hond();//aanroep van parameterloze constructor
            hond1.PrintGegevens();
            Hond hond2 = new Hond("Bobby","Collie");//aanroep van constructor met 2 parameters
            hond2.PrintGegevens();
            Hond hond3 = new Hond("Fifi", "Golden Retriever","Beige",2);//aanroep van constructor met 4 parameters
            hond3.PrintGegevens();
            //Hond1.SetNaam("Bobby");
            //Hond1.SetRas("Collie");

            //Hond2.SetNaam("Fifi");
            //Hond2.SetRas("Golden Retriever");

            //Console.WriteLine($"Hond : {Hond1.GetNaam()}, Ras: {Hond1.GetRas()}");
            //Console.WriteLine($"Hond : {Hond2.GetNaam()}, Ras: {Hond2.GetRas()}");
            //Console.WriteLine($"Hond : {Hond3.GetNaam()}, Ras: {Hond3.GetRas()}");
            //List<Hond> Honden = new List<Hond>();
            //Honden.Add(Hond1);
            //Honden.Add(Hond2);
            //Honden.Add(Hond3);

            //Console.WriteLine("Laten blafffen via foreach met list");
            //foreach (Hond hond in Honden)
            //{
            //    //Console.WriteLine($"{hond.GetNaam()} zegt woef!");
            //    hond.Spreek();
            //}

            //Console.WriteLine("Laten blaffen via object.Spreek()");
            //Hond1.Spreek();
            //Hond2.Spreek();
            //Hond3.Spreek();

        }
    }
}
