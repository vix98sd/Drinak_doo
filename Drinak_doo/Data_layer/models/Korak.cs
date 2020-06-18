using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class Korak
    {
        public Korak(int id_proizvod, int redni_broj, string opis)
        {
            Id_proizvod = id_proizvod;
            Redni_broj = redni_broj;
            Opis = opis;
        }

        public int Id_proizvod { get; set; }
        public int Redni_broj { get; set; }
        public string Opis { get; set; }
    }
}
