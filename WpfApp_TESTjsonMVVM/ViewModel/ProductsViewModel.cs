using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using WpfApp_TESTjsonMVVM.Model;

namespace WpfApp_TESTjsonMVVM.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                NotifyPropertyChanged();
            }
        }
        public ProductsViewModel()
        {
            LadenProducten();
        }
        public void LadenProducten()
        {
            Products = new ObservableCollection<Product>();
            string jsonString = @"[
                        {

                        'Name' : 'Windows',  

                        'ExpiryDate' : '2019-01-02',

                        'Price' : 103.99

                        },
                        {

                        'Name' : 'Apple',  

                        'ExpiryDate' : '2018-01-02',

                        'Price' : 3.99

                        }]";

            try

            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                ObservableCollection<Product> result = JsonConvert.DeserializeObject<ObservableCollection<Product>>(jsonString);
                Products = result;

               // DataContext = jsonClass;

            }

            catch (Exception ex)

            {
               Debug.Print(ex.Message);
                throw (ex);

            }
            //geeft running directory van de running appliction
            //encoding nodig om onleesbare tekens weg te werken
            //using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/Data/boeken.txt", Encoding.UTF7))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        String line = sr.ReadLine();
            //        //parsen van string naar character
            //        string[] substrings = line.Split(char.Parse(";"));

            //        Boeken.Add(new Boek(substrings[1], substrings[0], substrings[3], AppDomain.CurrentDomain.BaseDirectory + "/Resources/" + substrings[2]));
            //    }
            //}
        }
    }
}
