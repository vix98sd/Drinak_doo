using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Radnik
    {
        public Radnik(int id_radnik, string ime, string prezime, string telefon, string adresa, string jmbg, int id_pozicija)
        {
            Id_radnik = id_radnik;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Adresa = adresa;
            Jmbg = jmbg;
            SetPoz(id_pozicija);
        }

        public Radnik(int id_radnik, string ime, string prezime, string telefon, string adresa, string jmbg, Pozicija pozicija)
        {
            Id_radnik = id_radnik;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Adresa = adresa;
            Jmbg = jmbg;
            Poz = pozicija;
        }

        public int Id_radnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Jmbg { get; set; }
        public Pozicija Poz { get; set; }

        public string FunctionString { get; set; }
        public string ProcedureString { get; set; }

        private void SetPoz(int id_pozicija)
        {
            PozicijeRepository PR = new PozicijeRepository();
            Poz = PR.GetPozicija(id_pozicija);
            /*
            List<Pozicija> pozicije = PR.GetPozicije();

            foreach(Pozicija pozicija in pozicije)
            {
                if(pozicija.Id_pozicija == id_pozicija)
                {
                    Poz = pozicija;
                    break;
                }
            }
            */
        }

        public void DoFunction()
        {
            RadniciRepository RR = new RadniciRepository();
            FunctionString = RR.FunctionRadnik(Id_radnik);
        }

        public void DoProcedure()
        {
            RadniciRepository RR = new RadniciRepository();
            ProcedureString = RR.ProcedureRadnik(Id_radnik);
        }
    }
}
