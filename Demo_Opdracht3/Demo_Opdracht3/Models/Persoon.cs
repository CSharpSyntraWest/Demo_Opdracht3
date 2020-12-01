using Demo_Opdracht3.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Opdracht3.Models
{
    class Persoon : ObservableObject
    {
        private string _voornaam;
        private string _familienaam;
        private DateTime _geboorteDatum;
        public string Voornaam
        {
            get { return _voornaam; }
            set
            {
                OnPropertyChanged(ref _voornaam, value);
            }
        }
        public string Familienaam
        {
            get { return _familienaam; }
            set
            {
                OnPropertyChanged(ref _familienaam, value);
            }
        }
        public DateTime GeboorteDatum
        {
            get { return _geboorteDatum; }
            set
            {
                OnPropertyChanged(ref _geboorteDatum, value);
            }
        }
    }
 }
