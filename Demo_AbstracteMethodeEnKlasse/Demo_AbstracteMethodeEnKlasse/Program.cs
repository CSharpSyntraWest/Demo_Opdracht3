using System;

namespace Demo_AbstracteMethodeEnKlasse
{
    //Oefening:
    //Maak een afgeleide klasse Cirkel van Figuur die de methoden BerekenOppervlakte() en BerekenOmtrek()
    //(Je zal de abstracte overriden methoden moeten aanpassen zodat ze een double als terugkeerwaarde geven)
    // implenteert
    abstract class Figuur
    { 
        public string Kleur { get; set; }
        public abstract double BerekenOppervlakte();//abstracte methode: geen implementatie voorzien
        public abstract double BerekenOmtrek();//abstracte methode: geen implementatie voorzien
        public void Print()
        {
            Console.WriteLine($"Figuur Kleur {this.Kleur}");
        }
    }
    class Rechthoek : Figuur
    {

        public int Breedte { get; set; }
        public int Hoogte { get; set; }
        public override double BerekenOmtrek()
        {
            return (this.Breedte + this.Hoogte) * 2; ;
        }
        public override double BerekenOppervlakte()
        {
            return this.Breedte * this.Hoogte;
        }

    }
    class Vierkant : Figuur
    { 
        public int Zijde { get; set; }
        public override double BerekenOppervlakte()
        {
            return Zijde * Zijde;
        }
        public override double BerekenOmtrek()
        {
            return 4*Zijde;
        }
    }
    class Program
    {
        static void Main()
        {
            //Figuur figuur = new Figuur(); lukt niet bij abstracte klasse
            Vierkant vierkant = new Vierkant() { Zijde = 2 };
            Console.WriteLine("oppervlakte " + vierkant.BerekenOppervlakte());
        }
    }
}
