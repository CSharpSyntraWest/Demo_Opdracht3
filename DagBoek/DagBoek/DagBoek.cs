using System;
using System.Collections.Generic;
using System.Text;

namespace DagBoek
{
    enum Balans { Actief, Passief }
    enum CreditOfDebet { Credit, Debet }
    enum BTWCode { BTW0Perc = 0, BTW6Perc=6, BTW12Perc=12,BTW21Perc=21}
    class Rekening
    {
        public string Nummer { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
    }
    class DocInfo
    { 
        public string Prefix { get; set; }
        public string Nummer { get; set; }
        public byte[] Attachment { get; set; }

    }
    class BankRekening : Rekening
    {
        public string Bank { get; set; }
    }
    class GrootboekRekening : Rekening
    {
        public string Rubriek { get; set; }
        public string Onderdeel { get; set; }
        public Balans BalansZijde { get; set; }
        public CreditOfDebet TypeCD { get; set; }
    }
    class Journaal
    {
        public List<JournaalPost> _journaalPosten;
        public Journaal()
        {
            _journaalPosten = new List<JournaalPost>();             
        }

    }
    class JournaalPost
    {
        public string NaamId { get; set; }
        public int VolgNr { get; set; }
        public DocInfo Document { get; set; }
        public TypePost TypePost { get; set; }
        public DateTime BoekingsDatum { get; set; }
        public Rekening Rekening { get; set; }
        public double Bedrag { get; set; }
       // public CreditOfDebet TypeCD { get; set; }
    }
    class GrootBoekDagBoek : Journaal
    {

    }
    class AankoopDagBoek : Journaal
    {

    }
    class VerkoopDagBoek : Journaal
    {

    }
    class FinancieelDagBoek : Journaal
    {

    }
    class DiversenDagBoek : Journaal
    {}
    class BankDagBoek : FinancieelDagBoek
    { }

    class KasBoek : FinancieelDagBoek
    { }
    class TypePost
    { 
    }
    class Klant: TypePost
    { }
    class Leverancier: TypePost
    { }
    class Grootboek : TypePost { }
}
