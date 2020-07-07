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

            this.id_radnik = id_radnik;
            SetNapravio(null);
            this.id_proizvod = id_proizvod;
            SetNapravljen(null);

            //SetRadnik(this.id_radnik);
            //SetProizvod(id_proizvod);
        }

        public Pravljenje(Radnik radnik, Proizvod proizvod, int rbr_pravljenja, string datum, string napomena)
        {
            SetNapravio(radnik);
            SetNapravljen(proizvod);
            Redni_broj = rbr_pravljenja;
            Datum = datum;
            Napomena = napomena;
        }

        private int id_radnik;
        private Radnik napravio;
        public void SetNapravio(Radnik radnik)
        {
            napravio = radnik;
        }
        public Radnik GetNapravio()
        {
            if(napravio == null)
            {
                SetRadnik(id_radnik);
            }

            return napravio;
        }
        
        private int id_proizvod;
        private Proizvod napravljen;
        public void SetNapravljen(Proizvod proizvod)
        {
            napravljen = proizvod;
        }
        public Proizvod GetNapravljen()
        {
            if(napravljen == null)
            {
                SetProizvod(id_proizvod);
            }

            return napravljen;
        }
        
        public int Redni_broj { get; set; }
        public string Datum { get; set; }
        public string Napomena { get; set; }

        private void SetRadnik(int id_radnik)
        {


            RadniciRepository RR = new RadniciRepository();
            SetNapravio(RR.GetRadnik(id_radnik));

            /*
            List<Radnik> radnici = RR.GetRadnici();
            
            foreach(Radnik radnik in radnici)
            {
                if(radnik.Id_radnik == id_radnik)
                {
                    Napravio = radnik;
                    break;
                }
            }
            */
        }

        private void SetProizvod(int id_proizvod)
        {
            ProizvodRepository PR = new ProizvodRepository();
            SetNapravljen(PR.GetProizvod(id_proizvod));

            /*
            List<Proizvod> proizvodi = PR.GetProizvodi();

            foreach(Proizvod proizvod in proizvodi)
            {
                if(proizvod.Id_proizvod == id_proizvod)
                {
                    Napravljen = proizvod;
                    break;
                }
            }
            */
        }
    }
}
