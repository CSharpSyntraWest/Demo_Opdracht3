using System;
using System.Collections.Generic;

namespace Demos_Interfaces
{
    interface IFiguur //interfaces bevatten geen implementaties
    {
        double BerekenOppervlakte();// is automatisch public
        double BerekenOmtrek();
    }
    interface IResizable
    {
        void Resize(int weight);
        void Resize(int weightX, int weightY);
        void ResizeByX(int weightX);
        void ResizeByY(int weightY);

    }
    class ResizableRechthoek : IFiguur, IResizable
    { 
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public double BerekenOmtrek() //implementatie voorzien in klasse
        {
            return (Hoogte + Breedte) * 2;
        }

        public double BerekenOppervlakte() //implementatie voorzien in klasse
        {
            return Hoogte * Breedte;
        }
       
        public void Resize(int weight)
        {
            Console.WriteLine("Resize rechthoek met " + weight);
            Breedte *= weight;
            Hoogte *= weight;
        }

        public void Resize(int weightX, int weightY)
        {
            Console.WriteLine("Resize rechthoek x met " + weightX +" en y met "+ weightY);
            Breedte *= weightX;
            Hoogte *= weightY;
        }

        public void ResizeByX(int weightX)
        {
            Console.WriteLine("Resize rechthoek x met " + weightX );
            Breedte *= weightX;
        }

        public void ResizeByY(int weightY)
        {
            Console.WriteLine("Resize rechthoek  met " + weightY);
            Hoogte *= weightY;
        }
    }
    class Cirkel : IFiguur
    { 
        public double Straal { get; set; }

        public double BerekenOmtrek()
        {
            return 2 * Straal * Math.PI;
        }

        public double BerekenOppervlakte()
        {
            return Straal * Straal * Math.PI;
        }
    }
    class Rechthoek : IFiguur
    {
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public double BerekenOmtrek() //implementatie voorzien in klasse
        {
            return (Hoogte + Breedte) * 2;
        }

        public double BerekenOppervlakte() //implementatie voorzien in klasse
        {
            return Hoogte * Breedte;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IList<int> lijst = new List<int>();


            Rechthoek rechthoek = new Rechthoek() { Hoogte = 2, Breedte = 3 };
            Cirkel cirkel = new Cirkel { Straal = 1 };
            List<IFiguur> figuren = new List<IFiguur>();
            ResizableRechthoek resizableRechthoek = new ResizableRechthoek() { Hoogte = 2, Breedte = 3 };
            resizableRechthoek.Resize(2);
            figuren.Add(rechthoek);
            figuren.Add(cirkel);
            figuren.Add(resizableRechthoek);
            foreach (IFiguur figuur in figuren)
            {
                Console.WriteLine("omtrek:" + figuur.BerekenOmtrek());
                Console.WriteLine("oppervlak:" + figuur.BerekenOppervlakte());
            }
        }
    }
}
