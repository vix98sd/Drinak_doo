using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    class Sastojak
    {
        public int Id_proizvod { get; set; }
        public Magacin Roba { get; set; }
        public Kategorija Kategorija_sastojka { get; set; }
        public double Kolicina { get; set; }
        
    }
}
