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

        public string UpdateMagacin(Magacin roba)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "update magacin set" +
                             " naziv = \'" + roba.Naziv + "\'" +
                             ", kolicina = " + roba.Kolicina +
                             ", id_jm = " + roba.GetJM().Id_jm +
                             "where id_robe = " + roba.Id_robe;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste azurirali stanje u magacinu!";
                }
                catch
                {
                    return "Doslo je do greske prilikom azuriranja stanja u magacinu!";
                }
            }
        }

        public string UpdateMagacin(string sql)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno skinuta kolicina sa stanja!";
                }
                catch
                {
                    return "Doslo je do greske prilikom skidanja kolicine sa stanja!";
                }
            }
        }

        public string InsertRobu(Magacin roba)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into magacin values(" + roba.Id_robe +
                                                         ",\'" + roba.Naziv + "\'" +
                                                         "," + roba.Kolicina +
                                                         "," + roba.GetJM().Id_jm +")";

                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno uneta roba!";
                }
                catch
                {
                    return "Doslo je do greske prilikom unosenja robe!";
                }
            }
        }

        public string DeleteRobu(Magacin roba)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from magacin where id_robe = " + roba.Id_robe;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste obrisali " + roba.Naziv;
                }
                catch
                {
                    return "Dolso je do greske prilikom brisanja " + roba.Naziv;
                }
            }
        }
    }
}
