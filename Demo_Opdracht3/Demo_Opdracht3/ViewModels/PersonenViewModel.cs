using Demo_Opdracht3.Models;
using Demo_Opdracht3.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Opdracht3.ViewModels
{
    class PersonenViewModel : ObservableObject
    {
        private Persoon _huidigPersoon;
        private ObservableCollection<Persoon> _personenCollectie;
        public PersonenViewModel()
        {
            InitialiseerPersonenCollectie();     
        }
        private void InitialiseerPersonenCollectie()
        {
            List<Persoon> personen = new List<Persoon>()
            {
                new Persoon{ Voornaam ="Jan", Familienaam="Jansen",GeboorteDatum=new DateTime(2005,10,12)},
                new Persoon { Voornaam="Piet", Familienaam="Pieters",GeboorteDatum=new DateTime(2010,9,8)}
            };
            PersonenCollectie = new ObservableCollection<Persoon>(personen);
        }
        public Persoon HuidigPersoon
        {
            get {
                return _huidigPersoon;
            }
            set {
                _huidigPersoon = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<Persoon> PersonenCollectie
        {
            get { return _personenCollectie; }
            set { _personenCollectie = value;
                OnPropertyChanged();
            }
        }


    }
}
