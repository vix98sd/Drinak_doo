using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    class Proizvod
    {
        public int Id_proizvod { get; set; }
        public string Naziv { get; set; }
        public double Tezina { get; set; }
        public double Cena { get; set; }
        public string Napomena { get; set; }

        public LinkedList<Korak> Koraci { get; set; }

    }
}
