using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class KoraciRepository
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

        public List<Korak> GetKoraciByProizvod(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from koraci where id_proizvod = " + id_proizvod + " order by redni_broj";
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();

                List<Korak> koraci = new List<Korak>();

                while (dr.Read())
                {
                    Korak korak = new Korak(dr.GetInt32(0),
                                            dr.GetInt32(1),
                                            dr.GetString(2));
                    koraci.Add(korak);
                }

                return koraci;
            }
        }

        public string UpdateKorak(Korak korak)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "update koraci set opis = \'" + korak.Opis +
                             "\' where id_proizvod = " + korak.Id_proizvod +
                             " and redni_broj = " + korak.Redni_broj;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno azuriran korak!";
                }
                catch
                {
                    return "Greska prilikom azuriranja koraka!";
                }
            }
        }

        public string InsertKorak(Korak korak)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into koraci values(" + korak.Id_proizvod +
                             "," + korak.Redni_broj +
                             ", \'" + korak.Opis +
                             "\')";
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno unet novi korak!";
                }
                catch
                {
                    return "Greska prilikom unosenja novog koraka!";
                }


            }
        }

        public string DeleteKorake(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from koraci where id_proizvod = " + id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Koraci uspesno obrisani!";
                }
                catch
                {
                    return "Brisanje koraka nije uspelo!";
                }
            }
        }
    }
}