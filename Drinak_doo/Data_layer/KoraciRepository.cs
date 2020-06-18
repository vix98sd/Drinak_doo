using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public public class KoraciRepository
    {
        string connectionString = ConnectionString.GetString();

        public List<Korak> GetKoraci()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                string sql = "select * from koraci";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dataReader = command.ExecuteReader();

                List<Korak> koraci = new List<Korak>();

                while (dataReader.Read())
                {
                    Korak korak = new Korak(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetString(2));
                    koraci.Add(korak);
                }

                return koraci;
            }
        }
    }
}
