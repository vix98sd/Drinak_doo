using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_layer.models;
using Oracle.ManagedDataAccess.Client;

namespace Data_layer
{
    public class JediniceMereRepository
    {
        //string connectionString = ConnectionString.GetString();

        public List<JedinicaMere> GetJediniceMere()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "SELECT * FROM JEDINICE_MERE";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dataReader = command.ExecuteReader();

                List<JedinicaMere> jediniceMere = new List<JedinicaMere>();

                while (dataReader.Read())
                {
                    JedinicaMere jm = new JedinicaMere(dataReader.GetInt32(0), dataReader.GetString(1));
                    jediniceMere.Add(jm);
                }

                return jediniceMere;
            }
            /*OracleConnection con = new OracleConnection(connectionString);
            string s = "->";
            try
            {
                con.Open();
                string sql = "select * from jedinice_mere";
                OracleCommand oracleCommand = new OracleCommand(sql, con);
                OracleDataReader ODR = oracleCommand.ExecuteReader();

                while (ODR.Read())
                {

                JedinicaMere jm = new JedinicaMere(ODR.GetInt32(0), ODR.GetString(1));
                //s += ODR.GetInt64(0) + " " + ODR.GetString(1) + "\n";
                s += jm.Id_jm + " " + jm.Naziv;
                }
                //ODR.Read();
                //s += ODR.GetInt64(0) + " " + ODR.GetString(1) + "\n";

                con.Close();
            }
            catch(Exception e) {
                return "Konekcija sa bazom nije uspela!";
            }

            //return "Konekcija sa bazom je uspela!";
            return s;*/
        }

    }
}
