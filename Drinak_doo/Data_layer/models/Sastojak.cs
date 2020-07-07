using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Sastojak
    {
        public Sastojak(int id_proizvod, int id_roba, int id_kategorija, double kolicina)
        {
            Id_proizvod = id_proizvod;
            Kolicina = kolicina;
            this.id_roba = id_roba;
            roba = null;
            this.id_kategorija = id_kategorija;
            kategorija = null;
        }

        public Sastojak(int id_proizvod, Magacin roba, Kategorija kategorija, double kolicina)
        {
            Id_proizvod = id_proizvod;
            SetRoba(roba);
            SetKategorija(kategorija);
            Kolicina = kolicina;
        }

        public int Id_proizvod { get; set; }

        private int id_roba;
        private Magacin roba;
        public void SetRoba(Magacin roba)
        {
            this.roba = roba;
        }
        public Magacin GetRoba()
        {
            if (roba == null)
                SetRoba(id_roba);

            return roba;
        }

        private int id_kategorija;
        private Kategorija kategorija;
        public void SetKategorija(Kategorija kategorija)
        {
            this.kategorija = kategorija;
        }
        public Kategorija GetKategorija()
        {
            if(kategorija == null)
            {
                SetKategorija(id_kategorija);
            }
            return kategorija;
        }
        
        public double Kolicina { get; set; }

        private void SetRoba(int id_roba)
        {
            MagacinRepository MR = new MagacinRepository();
            SetRoba(MR.GetMagacinByID(id_roba));

            /*
            List<Magacin> svaRoba = MR.GetMagacin();

            foreach(Magacin roba in svaRoba)
            {
                if(roba.Id_robe == id_roba)
                {
                    Roba = roba;
                    break;
                }
            }
            */
        }

        private void SetKategorija(int id_kategorija)
        {
            KategorijeRepository KR = new KategorijeRepository();
            SetKategorija(KR.GetKategorijaByID(id_kategorija));

            /*
            List<Kategorija> sveKategorije = KR.GetKategorije();

            foreach (Kategorija kategorija in sveKategorije)
            {
                if(kategorija.Id_kategorija == id_kategorija)
                {
                    Kategorija_sastojka = kategorija;
                    break;
                }
            }
            */
        }

    }
}
