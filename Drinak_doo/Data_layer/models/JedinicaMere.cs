using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class JedinicaMere
    {
        public JedinicaMere(int id_jm, string naziv)
        {
            this.Id_jm = id_jm;
            this.Naziv = naziv;
        }

        public int Id_jm { get; set; }
        public string Naziv { get; set; }

    }
}
