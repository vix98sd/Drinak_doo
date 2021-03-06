﻿using Data_layer.models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class KategorijeRepository
    {
        //string connectionString = ConnectionString.GetString();

        public List<Kategorija> GetKategorije()
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from kategorije";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader dataReader = command.ExecuteReader();

                List<Kategorija> kategorije = new List<Kategorija>();

                while (dataReader.Read())
                {
                    Kategorija kategorija = new Kategorija(dataReader.GetInt32(0), dataReader.GetString(1));
                    kategorije.Add(kategorija);
                }

                return kategorije;
            }

        }

        public Kategorija GetKategorijaByID(int id_kategorija)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from kategorije where id_kategorija = " + id_kategorija;
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();
                dr.Read();

                Kategorija kategorija = new Kategorija(dr.GetInt32(0), dr.GetString(1));
                return kategorija;
            }
        }

    }
}
