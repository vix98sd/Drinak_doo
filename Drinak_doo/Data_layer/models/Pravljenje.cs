using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    class Pravljenje
    {
        public Radnik Napravio { get; set; }
        public Proizvod Napravljen { get; set; }
        public int Redni_broj { get; set; }
        public string Datum { get; set; }
        public string Napomena { get; set; }
    }
}
