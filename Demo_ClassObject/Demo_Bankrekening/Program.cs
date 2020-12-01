using System;

namespace Demo_Bankrekening
{
    class Bankrekening
    {
        private decimal _saldo;
        private string _ibanNummer;
        public void Stort(decimal bedrag)
        {
            _saldo += bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            _saldo -= bedrag;
        }
        public decimal GetSaldo()
        {
            return _saldo;
        }
        public void SetIbanNummer(string iban)
        {
            _ibanNummer=iban;
        }
        public string GetIbanNummer()
        {
            return _ibanNummer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankrekening[] bank = { new Bankrekening(), new Bankrekening(), new Bankrekening() };
            bank[0].SetIbanNummer("BE68539007547034");
            bank[1].SetIbanNummer("NL05RABO1234123400");
            bank[2].SetIbanNummer("LU280019400644750000");
            do
            {
                PrintSaldi(bank);
                Console.Write("Te bewerken bankrekening?: ");
                int keuze = int.Parse(Console.ReadLine());
                Bankrekening bankrekening = bank[keuze-1];
                Console.Write("Actie (stort/haalaf)?: ");
                string actie = Console.ReadLine().ToLower();
                decimal bedrag = 0m;
                if (actie == "stort" || actie == "haalaf")
                {
                    Console.WriteLine("Bedrag?: ");
                    bedrag = decimal.Parse(Console.ReadLine());
                    if (actie == "stort")
                    {
                        bankrekening.Stort(bedrag);
                    }
                    else
                    {
                        bankrekening.HaalAf(bedrag);
                    }
                }
                else
                {
                    Console.WriteLine("Geen geldige actie");
                }

            } while (true);
            //Bankrekening rekening1 = new Bankrekening();
            //rekening1.SetIbanNummer("BE68539007547034");
            //Bankrekening rekening2 = new Bankrekening();
            //rekening2.SetIbanNummer("NL05RABO1234123400");
            //rekening1.Stort(100m);
            //rekening2.HaalAf(200m);
            //Console.WriteLine($"{rekening1.GetIbanNummer()}: {rekening1.GetSaldo()}");
            //Console.WriteLine($"{rekening2.GetIbanNummer()}: {rekening2.GetSaldo()}");
        }
        static void PrintSaldi(Bankrekening[] rekeningen)
        {
            int counter=1;
            foreach (Bankrekening rekening in rekeningen)
            {

                Console.WriteLine($"{counter++}: {rekening.GetIbanNummer()} - Saldo: {rekening.GetSaldo()}");
            }
        }
    }

}
