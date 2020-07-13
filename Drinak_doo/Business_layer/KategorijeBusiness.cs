using Data_layer.models;
using Data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class KategorijeBusiness
    {
        public List<Kategorija> GetKategorije()
        {
            KategorijeRepository KR = new KategorijeRepository();
            return KR.GetKategorije();
        }

        public List<Kategorija> GetKategorijeIzvanListe(List<Kategorija> izListe)
        {
            List<Kategorija> izvanListe = new List<Kategorija>();
            List<Kategorija> sve = GetKategorije();

            foreach (Kategorija kategorija in sve)
            {
                if (!izListe.Contains(kategorija))
                {
                    izvanListe.Add(kategorija);
                }
            }

            return izvanListe;
        }

    }
}
