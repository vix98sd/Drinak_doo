using Data_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class MagacinBusiness
    {
        public List<Magacin> GetRobu()
        {
            MagacinRepository MR = new MagacinRepository();
            return MR.GetMagacin();
        }

        public string UpdateMagacin(Magacin roba)
        {
            return new MagacinRepository().UpdateMagacin(roba);
        }

        public string InsertRobu(Magacin roba)
        {
            roba.Id_robe = FreeID();
            return new MagacinRepository().InsertRobu(roba);
        }

        public string DeleteRobu(Magacin roba)
        {
            return new MagacinRepository().DeleteRobu(roba);
        }

        public string UpdateMagacin(string sql)
        {
            return new MagacinRepository().UpdateMagacin(sql);
        }

        public int FreeID()
        {
            List<Magacin> roba = GetRobu();
            int id = -1;

            foreach(Magacin r in roba)
            {
                if (r.Id_robe > id)
                    id = r.Id_robe;
            }

            return id + 1;
        }
    }
}
