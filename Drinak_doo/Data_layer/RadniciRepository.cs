using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class RadniciRepository
    {
        public List<Radnik> GetRadnici()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from radnici";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Radnik> radnici = new List<Radnik>();

                while (dr.Read())
                {
                    Radnik radnik = new Radnik(dr.GetInt32(0),
                                               dr.GetString(1), 
                                               dr.GetString(2), 
                                               dr.GetString(3), 
                                               dr.GetString(4), 
                                               dr.GetString(5), 
                                               dr.GetInt32(6));
                    radnici.Add(radnik);
                }

                return radnici;
            }
        }

        public Radnik GetRadnik(int id_radnik)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from radnici where id_radnik = " + id_radnik;
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();
                dr.Read();

                Radnik radnik = new Radnik(dr.GetInt32(0),
                                           dr.GetString(1), 
                                           dr.GetString(2), 
                                           dr.GetString(3), 
                                           dr.GetString(4), 
                                           dr.GetString(5), 
                                           dr.GetInt32(6));

                return radnik;
            }
        }

        public string UpdateRadnik(Radnik radnik)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = @"update radnici"
                            +" set ime=\'"+radnik.Ime
                            +"\', prezime=\'"+radnik.Prezime
                            +"\', telefon=\'"+radnik.Telefon
                            +"\', adresa=\'"+radnik.Adresa
                            +"\', jmbg=\'"+radnik.Jmbg
                            +"\', id_pozicija="+radnik.Poz.Id_pozicija
                            +" where id_radnik=" + radnik.Id_radnik;

                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno azuriran radnik!";
                }
                catch
                {
                    return "Azuriranje nije uspelo!";
                }
            }
        }

        public string InsertRadnik(Radnik radnik)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into radnici values(" + radnik.Id_radnik +
                                                      ",\'" + radnik.Ime +
                                                      "\',\'" + radnik.Prezime +
                                                      "\',\'" + radnik.Telefon +
                                                      "\',\'" + radnik.Adresa +
                                                      "\',\'" + radnik.Jmbg +
                                                      "\'," + radnik.Poz.Id_pozicija +
                                                      ")";
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste dodali radnika!";
                }
                catch
                {
                    return "Dodavanje radnika nije uspelo!";
                }

            }
        }

        public string DeleteRadnik(int id_radnik)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from radnici where id_radnik = " + id_radnik;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste obrisali radnika!";
                }
                catch
                {
                    return "Doslo je do greske prilikom brisanja radnika!";
                }
            }
        }

        public string FunctionRadnik(int id_radnik)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select get_worker_most(" + id_radnik + ") from dual";
                OracleCommand command = new OracleCommand(sql, connection);
                try
                {
                    OracleDataReader dr = command.ExecuteReader();
                    dr.Read();
                    return dr.GetString(0);
                }
                catch
                {
                    return "Nije uspelo izvrsavanje SQL funkcije!";
                }
            }
        }

        public string ProcedureRadnik(int id_radnik)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "get_worker_level";
                OracleCommand command = new OracleCommand(sql, connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("p_id_radnik", OracleDbType.Int32).Value = id_radnik;
                command.Parameters.Add("p_level", OracleDbType.Varchar2, 32767).Direction = System.Data.ParameterDirection.Output;

                try
                {
                    command.ExecuteNonQuery();
                    return command.Parameters["p_level"].Value.ToString();
                }
                catch
                {
                    return "Nije uspoelo izvrsavanje PL/SQL procedure!";
                }

            }
        }

    }
}
