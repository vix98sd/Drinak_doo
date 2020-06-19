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

        public string UpdateProizvod(Proizvod proizvod)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "update proizvodi set naziv =\'" + proizvod.Naziv +
                                                 "\', tezina =" + proizvod.Tezina +
                                                 ", cena =" + proizvod.Cena +
                                                 ", napomena =\'" + proizvod.Napomena +
                                                 "\' where id_proizvod = " + proizvod.Id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno azuriran proizvod!";
                }
                catch
                {
                    return "Azuriranje proizvoda nije uspelo!";
                }
            }
        }

        public string InsertProizvod(Proizvod proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into proizvodi values("  + proizvod.Id_proizvod +
                                                          ",\'" + proizvod.Naziv +
                                                          "\'," + proizvod.Tezina +
                                                          "," + proizvod.Cena +
                                                          ",\'" + proizvod.Napomena +
                                                          "\')";
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno dodat novi proizvod!";
                }
                catch
                {
                    return "Doslo je do greske prilikom unosa novog proizvoda!";
                }
            }
        }
    }
}
