using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer.models
{
    public class MagacinRepository
    {
        public List<Magacin> GetMagacin()
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from magacin";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Magacin> magacin = new List<Magacin>();

                while (dr.Read())
                {
                    Magacin roba = new Magacin(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3));
                    magacin.Add(roba);
                }

                return magacin;
            }
        }

        public Magacin GetMagacinByID(int id_robe)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from magacin where id_robe = " + id_robe;
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();
                dr.Read();

                Magacin roba = new Magacin(dr.GetInt32(0),
                                           dr.GetString(1),
                                           dr.GetDouble(2),
                                           dr.GetInt32(3));

                return roba;
            }
        }
    }
}
