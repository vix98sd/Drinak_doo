using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Pravljenje
    {
        public Pravljenje(int id_radnik, int id_proizvod, int rbr_pravljenja, string datum, string napomena)
        {
            Redni_broj = rbr_pravljenja;
            Datum = datum;
            Napomena = napomena;
            SetRadnik(id_radnik);
            SetProizvod(id_proizvod);
        }

        public Pravljenje(Radnik radnik, Proizvod proizvod, int rbr_pravljenja, string datum, string napomena)
        {
            Napravio = radnik;
            Napravljen = proizvod;
            Redni_broj = rbr_pravljenja;
            Datum = datum;
            Napomena = napomena;
        }

        public Radnik Napravio { get; set; }
        public Proizvod Napravljen { get; set; }
        public int Redni_broj { get; set; }
        public string Datum { get; set; }
        public string Napomena { get; set; }

        private void SetRadnik(int id_radnik)
        {
            RadniciRepository RR = new RadniciRepository();
            List<Radnik> radnici = RR.GetRadnici();
            
            foreach(Radnik radnik in radnici)
            {
                if(radnik.Id_radnik == id_radnik)
                {
                    Napravio = radnik;
                    break;
                }
            }
        }

        private void SetProizvod(int id_proizvod)
        {
            ProizvodRepository PR = new ProizvodRepository();
            List<Proizvod> proizvodi = PR.GetProizvodi();

            foreach(Proizvod proizvod in proizvodi)
            {
                if(proizvod.Id_proizvod == id_proizvod)
                {
                    Napravljen = proizvod;
                    break;
                }
            }
        }
    }
}
