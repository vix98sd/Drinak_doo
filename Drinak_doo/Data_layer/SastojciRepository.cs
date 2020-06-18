using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class SastojciRepository
    {
        public List<Sastojak> GetSastojke()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from sastojci";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Sastojak> sastojci = new List<Sastojak>();

                while (dr.Read())
                {
                    Sastojak sastojak = new Sastojak(dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetDouble(3));
                    sastojci.Add(sastojak);
                }

                return sastojci;
            }
        }
    }
}
