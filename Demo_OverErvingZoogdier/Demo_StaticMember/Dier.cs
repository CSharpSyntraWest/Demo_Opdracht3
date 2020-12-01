using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Polymorfisme_Kinderboerderij
{
    class Dier
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public virtual void Spreek()
        {
            Console.WriteLine($"{Kleur} dier maakt geluid");
        }
    }

    class Hond : Dier
    {
        public string Ras { get; set; }
        private static int _aantal;
        public static int Aantal { get { return _aantal; } }
        public Hond()
        {
            _aantal++;
        }
        public override void Spreek()
        {
            //base.Spreek();
            Console.WriteLine($"{Naam} zegt Woef!");
        }
    }
    class Kat : Dier
    { 
        public int AantalMuizenPerDag { get; set; }
        private static int _aantal;
        public static int Aantal { get { return _aantal; } }
        public Kat()
        {
            _aantal++;
        }
        public override void Spreek()
        {
            Console.WriteLine($"{Naam} zegt Miaauuuw");
        }
    }
    class Kip : Dier
    {
        private static int _aantal;
        public static int Aantal { get { return _aantal; } }
        public Kip()
        {
            _aantal++;
        }
        public int EierenPerDag { get; set; }
        public override void Spreek()
        {
            Console.WriteLine($"{Naam} zegt Tok toook");
        }
    }


}
