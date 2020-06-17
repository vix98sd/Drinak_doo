using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    class Radnik
    {
        public int Id_radnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Jmbg { get; set; }
        public Pozicija Poz { get; set; }

    }
}
