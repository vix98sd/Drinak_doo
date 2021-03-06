﻿using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class PravljenjaRepository
    {
        public List<Pravljenje> GetPravljenja()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from pravljenje order by datum, rbr_pravljenja";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<Pravljenje> pravljenja = new List<Pravljenje>();

                while (dr.Read())
                {
                    string datum = dr.GetDateTime(3).ToString().Trim();
                    Pravljenje pravljenje = new Pravljenje(dr.GetInt32(0), 
                                                           dr.GetInt32(1),
                                                           dr.GetInt32(2),
                                                           datum.Replace(" 00:00:00",""),
                                                           dr.GetString(4));
                    pravljenja.Add(pravljenje);
                }

                return pravljenja;
            }
        }

        public List<Pravljenje> GetPravljenjaNaDan(int id_radnik, int id_proizvod, string date)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from pravljenje where id_radnik = " + id_radnik + " and id_proizvod = " + id_proizvod + " and datum = \'" + date + "\'";
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();
                List<Pravljenje> pravljenjaNaDan = new List<Pravljenje>();

                while (dr.Read())
                {
                    string datum = dr.GetDateTime(3).ToString().Trim();
                    Pravljenje pravljenje = new Pravljenje(dr.GetInt32(0),
                                                           dr.GetInt32(1),
                                                           dr.GetInt32(2),
                                                           datum.Replace(" 00:00:00", ""),
                                                           dr.GetString(4));
                    pravljenjaNaDan.Add(pravljenje);
                }

                return pravljenjaNaDan;
            }
        }

        public List<String> GetDatume()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select distinct datum from pravljenje";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dr = command.ExecuteReader();

                List<string> datumi = new List<string>();

                while (dr.Read())
                {
                    string datum = dr.GetDateTime(0).Date.ToString();
                    datum = datum.Replace("00:00:00", "").Trim();
                    datumi.Add(datum);
                }

                return datumi;
            }
        }

        public string DeletePravljenja(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from pravljenje where id_proizvod = " + id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno obrisana pravljenja!";
                }
                catch
                {
                    return "Doslo je do greske prilikom brisanja pravljenja!";
                }
            }
        }

        public string InsertPravljenje(Pravljenje pravljenje)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "insert into pravljenje values(" + pravljenje.GetNapravio().Id_radnik +
                             "," + pravljenje.GetNapravljen().Id_proizvod +
                             "," + pravljenje.Redni_broj +
                             ",\'" + pravljenje.Datum +
                             "\',\'" + pravljenje.Napomena +
                             "\')";
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste napravili proizvod!";
                }
                catch
                {
                    return "Pravljenje proizvoda nije uspelo!";
                }
            }
        }
    }
}
