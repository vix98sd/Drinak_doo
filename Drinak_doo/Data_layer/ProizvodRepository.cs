using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class ProizvodRepository
    {
        public List<Proizvod> GetProizvodi()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from proizvodi";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Proizvod> proizvodi = new List<Proizvod>();

                while (dr.Read())
                {
                    Proizvod proizvod = new Proizvod(dr.GetInt32(0), dr.GetString(1), dr.GetDouble(2), dr.GetDouble(3), dr.GetString(4));
                    proizvodi.Add(proizvod);
                }

                return proizvodi;
            }
        }
    }
}
