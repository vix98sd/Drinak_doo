using Data_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class SastojciBusiness
    {
        public string InsertSastojak(Sastojak sastojak, string eksplicitnoZadatNaziv)
        {
            SastojciRepository SR = new SastojciRepository();
            return SR.InsertSastojak(sastojak, eksplicitnoZadatNaziv);
        }

        public string UpdateSastojak(Sastojak sastojak)
        {
            SastojciRepository SR = new SastojciRepository();
            return SR.UpdateSastojak(sastojak);
        }

        public string DeleteSastojke(int id_proizvod)
        {
            SastojciRepository SR = new SastojciRepository();
            return SR.DeleteSastojke(id_proizvod);
        }
    }
}
