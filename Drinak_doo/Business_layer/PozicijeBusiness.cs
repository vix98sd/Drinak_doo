using Data_layer.models;
using Data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class PozicijeBusiness
    {
        public List<Pozicija> GetPozicije()
        {
            PozicijeRepository PR = new PozicijeRepository();
            return PR.GetPozicije();
        }
    }
}
