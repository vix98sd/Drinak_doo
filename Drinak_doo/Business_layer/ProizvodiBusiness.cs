using Data_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class ProizvodiBusiness
    {
        public List<Proizvod> GetProizvodi()
        {
            ProizvodRepository PR = new ProizvodRepository();
            return PR.GetProizvodi();
        }

        public List<Proizvod> GetProizvodiSaReceptom()
        {
            ProizvodRepository PR = new ProizvodRepository();
            List<Proizvod> sviProizvodi = PR.GetProizvodi();

            List<Proizvod> saReceptom = new List<Proizvod>();

            foreach(Proizvod proizvod in sviProizvodi)
            {
                if(proizvod.GetKoraci() != null && proizvod.GetSastojci() != null)
                {
                    saReceptom.Add(proizvod);
                }
            }

            return saReceptom;
        }

        public string UpdateProizvod(Proizvod proizvod)
        {
            ProizvodRepository PR = new ProizvodRepository();
            return PR.UpdateProizvod(proizvod);
        }

        public string InsertProizvod(Proizvod proizvod)
        {
            ProizvodRepository PR = new ProizvodRepository();
            return PR.InsertProizvod(proizvod);
        }

        public int FreeID()
        {
            int id = -1;
            List<Proizvod> proizvodi = GetProizvodi();

            foreach(Proizvod proizvod in proizvodi)
            {
                if (proizvod.Id_proizvod > id)
                    id = proizvod.Id_proizvod;
            }

            return id+1;
        }
        
        public string DeleteProizvod(int id_proizvod)
        {
            new PravljenjaBusiness().DeletePravljenja(id_proizvod);
            DeleteRecept(id_proizvod);
            return new ProizvodRepository().DeleteProizvod(id_proizvod);
        }

        public string DeleteRecept(int id_proizvod)
        {
            if(new KoraciBusiness().DeleteKorake(id_proizvod).Equals("Uspesno obrisani koraci!") &&
               new SastojciBusiness().DeleteSastojke(id_proizvod).Equals("Uspesno obrisani sastojci!"))
            {
                return "Uspesno obrisan recept!";
            }
            else
            {
                return "Nije uspelo brisanje recepta!";
            }
        }
    }
}
