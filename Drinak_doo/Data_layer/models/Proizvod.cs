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
            koraci = null;
            sastojci = null;
        }

        public Proizvod(int id_proizvod, string naziv, double tezina, double cena, string napomena)
        {
            Id_proizvod = id_proizvod;
            Naziv = naziv;
            Tezina = tezina;
            Cena = cena;
            Napomena = napomena;
            koraci = null;
            sastojci = null;
        }

        public int Id_proizvod { get; set; }
        public string Naziv { get; set; }
        public double Tezina { get; set; }
        public double Cena { get; set; }
        public string Napomena { get; set; }

        private List<Korak> koraci;
        public void SetKoraci(List<Korak> koraci)
        {
            this.koraci = koraci;

            if (this.koraci == null)
                this.koraci = new List<Korak>();
        }
        public List<Korak> GetKoraci()
        {
            if(koraci == null)
            {
                SetKoraci();
            }
            return koraci;
        }

        private List<Sastojak> sastojci;
        public void SetSastojci(List<Sastojak> sastojci)
        {
            this.sastojci = sastojci;

            if(this.sastojci == null)
                this.sastojci = new List<Sastojak>();
        }

        public List<Sastojak> GetSastojci()
        {
            if(sastojci == null)
            {
                SetSastojci();
            }
            return sastojci;
        }

        private void SetKoraci()
        {
            KoraciRepository koraciRepository = new KoraciRepository();
            SetKoraci(koraciRepository.GetKoraciByProizvod(Id_proizvod));

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
            SetSastojci(SR.GetSastojkeByProizvod(Id_proizvod));

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
