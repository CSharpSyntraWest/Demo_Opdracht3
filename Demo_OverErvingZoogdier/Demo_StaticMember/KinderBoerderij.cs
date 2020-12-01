using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Polymorfisme_Kinderboerderij
{
    
    class KinderBoerderij
    {
        public string Naam { get; set; }
        public List<Dier> Dieren { get; private set; }

        public KinderBoerderij(string naam)
        {
            Naam = naam;
            Dieren = new List<Dier>();
        }
        public void MaakBoerderijGeluiden()
        {
            foreach (Dier dier in Dieren)
            {
                dier.Spreek();
            }
        }

        public void VoegDierToe(Dier dier)
        {
            Dieren.Add(dier);
        }
    }
}
