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

        public string InsertSastojak(Sastojak sastojak, string eksplicitnoZadatNaziv)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into sastojci values(" + sastojak.Id_proizvod +
                                                        "," + sastojak.Roba.Id_robe +
                                                        "," + sastojak.Kategorija_sastojka.Id_kategorija +
                                                        "," + sastojak.Kolicina +
                                                        ",\'" + eksplicitnoZadatNaziv +  
                                                        "\')";
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno unet nov sastojak!";
                }
                catch
                {
                    return "Doslo je do greske pri unosu novog sastojka!";
                }
            }
        }

        public string UpdateSastojak(Sastojak sastojak)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "update sastojci set kolicina =" +sastojak.Kolicina+
                    " where id_proizvod =" + sastojak.Id_proizvod+
                    " and id_robe =" + sastojak.Roba.Id_robe+
                    " and id_kategorija =" + sastojak.Kategorija_sastojka.Id_kategorija;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste azurirali sastojak!";
                }
                catch
                {
                    return "Doslo je do greske prilikom aziruranja sastojka!";
                }
            }
        }

        public string DeleteSastojke(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from sastojci where id_proizvod = " + id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno obrisani sastojci!";
                }
                catch
                {
                    return "Brisanje sastojaka nije uspelo!";
                }
            }
        }
    }
}
