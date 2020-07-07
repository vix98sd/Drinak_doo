using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Proizvod
    {
        public Proizvod()
        {
            Koraci = new List<Korak>();
            Sastojci = new List<Sastojak>();
        }

        public Proizvod(int id_proizvod, string naziv, double tezina, double cena, string napomena)
        {
            Id_proizvod = id_proizvod;
            Naziv = naziv;
            Tezina = tezina;
            Cena = cena;
            Napomena = napomena;
            SetKoraci();
            SetSastojci();
        }

        public int Id_proizvod { get; set; }
        public string Naziv { get; set; }
        public double Tezina { get; set; }
        public double Cena { get; set; }
        public string Napomena { get; set; }

        public List<Korak> Koraci { get; set; }

        public List<Sastojak> Sastojci { get; set; }

        private void SetKoraci()
        {
            KoraciRepository koraciRepository = new KoraciRepository();
            Koraci = koraciRepository.GetKoraciByProizvod(Id_proizvod);

            /*
            List<Korak> sviKoraci = koraciRepository.GetKoraci();

            Koraci = new List<Korak>();

            foreach(Korak korak in sviKoraci)
            {
                if(korak.Id_proizvod == Id_proizvod)
                {
                    Koraci.Add(korak);
                }
            }
            */
        }

        private void SetSastojci()
        {
            SastojciRepository SR = new SastojciRepository();
            Sastojci = SR.GetSastojkeByProizvod(Id_proizvod);

            /*
            List<Sastojak> sviSastojci = SR.GetSastojke();

            Sastojci = new List<Sastojak>();

            foreach(Sastojak sastojak in sviSastojci)
            {
                if(sastojak.Id_proizvod == Id_proizvod)
                {
                    Sastojci.Add(sastojak);
                }
            }
            */
        }
    }
}
