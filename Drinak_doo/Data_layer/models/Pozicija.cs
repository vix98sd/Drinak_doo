using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Pozicija
    {
        public Pozicija(int id, string naziv)
        {
            Id_pozicija = id;
            Naziv = naziv;
        }
        public int Id_pozicija { get; set; }
        public string Naziv { get; set; }

    }
}
