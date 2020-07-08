using Data_layer.models;
using Data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class RadniciBusiness
    {
        public List<Radnik> GetRadnici()
        {
            RadniciRepository RR = new RadniciRepository();
            List<Radnik> radnici = RR.GetRadnici();
            for(int i = 0; i < radnici.Count; i++)
            {
                radnici[i].DoFunction();
                radnici[i].DoProcedure();
            }

            return radnici;
        }
        
        public string UpdateRadnik(Radnik radnik)
        {
            RadniciRepository RR = new RadniciRepository();
            return RR.UpdateRadnik(radnik);
        }

        public string InsertRadnik(Radnik radnik)
        {
            RadniciRepository RR = new RadniciRepository();
            return RR.InsertRadnik(radnik);
        }
        public string DeleteRadnik(int id_radnik)
        {
            return new RadniciRepository().DeleteRadnik(id_radnik);
        }
        public bool IsManager(Radnik radnik)
        {
            return (radnik.Poz.Naziv.Equals("Vlasnik") || radnik.Poz.Naziv.Equals("Manager"));
        }

        public bool IsNotManager(Radnik radnik)
        {
            return !IsManager(radnik);
        }
    }
}
