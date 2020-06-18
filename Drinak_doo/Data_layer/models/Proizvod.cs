using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Proizvod
    {
        public Proizvod(int id_proizvod, string naziv, double tezina, double cena, string napomena)
        {
            Id_proizvod = id_proizvod;
            Naziv = naziv;
            Tezina = tezina;
            Cena = cena;
            Napomena = napomena;
            SetKoraci();
        }

        public int Id_proizvod { get; set; }
        public string Naziv { get; set; }
        public double Tezina { get; set; }
        public double Cena { get; set; }
        public string Napomena { get; set; }

        public List<Korak> Koraci { get; set; }

        private void SetKoraci()
        {
            KoraciRepository koraciRepository = new KoraciRepository();
            List<Korak> sviKoraci = koraciRepository.GetKoraci();

            foreach(Korak korak in sviKoraci)
            {
                if(korak.Id_proizvod == Id_proizvod)
                {
                    Koraci.Add(korak);
                }
            }

        }
    }
}
