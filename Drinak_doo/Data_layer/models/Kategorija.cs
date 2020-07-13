using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Kategorija
    {
        public Kategorija(int id, string naziv)
        {
            Id_kategorija = id;
            Naziv = naziv;
        }

        public int Id_kategorija { get; set; }
        public string Naziv { get; set; }

    }
}
