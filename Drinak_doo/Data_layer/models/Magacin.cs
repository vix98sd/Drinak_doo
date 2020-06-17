using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    class Magacin
    {
        public int Id_robe { get; set; }
        public string Naziv { get; set; }
        public double Kolicina { get; set; }
        public JedinicaMere Jm { get; set; }

    }
}
