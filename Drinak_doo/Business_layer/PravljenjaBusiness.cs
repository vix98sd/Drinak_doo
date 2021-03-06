﻿using Data_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class PravljenjaBusiness
    {
        public List<Pravljenje> GetPravljenja()
        {
            PravljenjaRepository PR = new PravljenjaRepository();
            return PR.GetPravljenja();
        }

        public List<string> GetDatume()
        {
            PravljenjaRepository PR = new PravljenjaRepository();
            return PR.GetDatume();
        }

        public string InsertPravljenje(Pravljenje pravljenje)
        {
            PravljenjaRepository PR = new PravljenjaRepository();

            string sql = "begin ";
            foreach(Sastojak sastojak in pravljenje.GetNapravljen().GetSastojci())
            {
                sql += "update magacin set kolicina = kolicina - " + sastojak.Kolicina + " where id_robe = " + sastojak.GetRoba().Id_robe + "; ";
            }
            sql += "end;";

            new MagacinBusiness().UpdateMagacin(sql);
            return PR.InsertPravljenje(pravljenje);
        }

        public string DeletePravljenja(int id_proizvod)
        {
            return new PravljenjaRepository().DeletePravljenja(id_proizvod);
        }

        public int GetTodaysRbr(int id_radnik, int id_proizvod, string date)
        {
            List<Pravljenje> pravljenjaNaDan = new PravljenjaRepository().GetPravljenjaNaDan(id_radnik, id_proizvod, date);
            int brojac = 0;

            foreach(Pravljenje pravljenje in pravljenjaNaDan)
            {
                brojac++;
            }

            return brojac + 1;
        }
    }
}
