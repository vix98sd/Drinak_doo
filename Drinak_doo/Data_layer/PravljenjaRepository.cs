using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class PravljenjaRepository
    {
        public List<Pravljenje> GetPravljenja()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from pravljenja";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Pravljenje> pravljenja = new List<Pravljenje>();

                while (dr.Read())
                {
                    Pravljenje pravljenje = new Pravljenje(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetString(3), dr.GetString(4));
                    pravljenja.Add(pravljenje);
                }

                return pravljenja;
            }
        }
    }
}
