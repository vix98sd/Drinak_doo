using Data_layer.models;
using Data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class KoraciBusiness
    {
        public string InsertKorak(Korak korak)
        {
            KoraciRepository KR = new KoraciRepository();
            return KR.InsertKorak(korak);
        }

        public string UpdateKorak(Korak korak)
        {
            KoraciRepository KR = new KoraciRepository();
            return KR.UpdateKorak(korak);
        }

        public string DeleteKorake(int id_poroizvod)
        {
            KoraciRepository KR = new KoraciRepository();
            return KR.DeleteKorake(id_poroizvod);
        }
    }
}
