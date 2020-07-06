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
            SetRoba(id_roba);
            SetKategorija(id_kategorija);
        }

        public Sastojak(int id_proizvod, Magacin roba, Kategorija kategorija, double kolicina)
        {
            Id_proizvod = id_proizvod;
            Roba = roba;
            Kategorija_sastojka = kategorija;
            Kolicina = kolicina;
        }

        public int Id_proizvod { get; set; }
        public Magacin Roba { get; set; }
        public Kategorija Kategorija_sastojka { get; set; }
        public double Kolicina { get; set; }

        private void SetRoba(int id_roba)
        {
            MagacinRepository MR = new MagacinRepository();
            Roba = MR.GetMagacinByID(id_roba);

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
            Kategorija_sastojka = KR.GetKategorijaByID(id_kategorija);

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
