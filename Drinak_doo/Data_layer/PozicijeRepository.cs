using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class PozicijeRepository
    {
        string connectionString = ConnectionString.GetString();

        public List<Pozicija> GetPozicije()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string sql = "select * from pozicije";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dataReader = command.ExecuteReader();

                List<Pozicija> pozicije = new List<Pozicija>();

                while (dataReader.Read())
                {
                    Pozicija pozicija = new Pozicija(dataReader.GetInt32(0), dataReader.GetString(1));
                    pozicije.Add(pozicija);
                }

                return pozicije;
            }
        }
    }
}
