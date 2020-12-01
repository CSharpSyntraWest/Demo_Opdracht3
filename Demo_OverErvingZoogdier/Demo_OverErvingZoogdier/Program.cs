using System;

namespace Demo_OverErvingZoogdier
{
    class Zoogdier
    { 
        public int Leeftijd { get; set; }
        public Zoogdier(int leeftijd)
        {
            this.Leeftijd = leeftijd;
        }
        public void Slaap()
        {
            Console.WriteLine("Sssst! Ik slaap!");

        }
    }
    class Hond : Zoogdier //Hond is afgeleide klasse van Zoogdier
    { 
        public string Ras { get; set; }//uitbreiding; extra property Ras
        public Hond(int leeftijd, string ras) : base(leeftijd)
        {
            this.Ras = ras;
        }
        public void Kwispel() //uitbreiding; extra methode Kwispel
        {
            Console.WriteLine("Aan het kwispelen...");

        }
    }
    class Program
    {
        static void Main()
        {
            Hond hond1 = new Hond(2, "Golden Retriever");
            Console.WriteLine($"Hond Ras = {hond1.Ras} Leeftijd= {hond1.Leeftijd}");
            hond1.Slaap();
            hond1.Kwispel();
            Zoogdier zoogdier = new Zoogdier(3);
            Console.WriteLine($"Zoogdier Leeftijd= {zoogdier.Leeftijd}");
            zoogdier.Slaap();
            
        }
    }
}
