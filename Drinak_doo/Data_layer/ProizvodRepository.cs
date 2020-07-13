using Data_layer.models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
                string sql = "select * from proizvodi order by id_proizvod";
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

        public Proizvod GetProizvod(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "select * from proizvodi where id_proizvod = " + id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                OracleDataReader dr = command.ExecuteReader();
                dr.Read();

                Proizvod proizvod = new Proizvod(dr.GetInt32(0),
                                                 dr.GetString(1), 
                                                 dr.GetDouble(2), 
                                                 dr.GetDouble(3), 
                                                 dr.GetString(4));
                return proizvod;
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

        public string DeleteProizvod(int id_proizvod)
        {
            using(OracleConnection connection = new OracleConnection(ConnectionString.GetString()))
            {
                connection.Open();
                string sql = "delete from proizvodi where id_proizvod = " + id_proizvod;
                OracleCommand command = new OracleCommand(sql, connection);

                try
                {
                    command.ExecuteNonQuery();
                    return "Uspesno ste obrisali proizvod!";
                }
                catch
                {
                    return "Doslo je do greske prilikom brisanja proizvoda!";
                }
            }
        }

        public bool ShowReceptPDF(Proizvod proizvod)
        {
            using (iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4))
            {
                try
                {
                    string fileName = proizvod.Naziv.Replace(" ", "_") + "_recept.pdf";
                    PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                    doc.Open();
                    string recept = "OSNOVNI PODACI:\n" +
                                    "Naziv: " + proizvod.Naziv + "\n" +
                                    "Tezina: " + proizvod.Tezina + "\n" +
                                    "Cena: " + proizvod.Cena + "\n" +
                                    "Napomena: " + proizvod.Napomena + "\n\n\n" +
                                    "SASTOJCI:\n";

                    int i = 1;
                    foreach(Sastojak sastojak in proizvod.GetSastojci())
                    {
                        recept += i + ". " + sastojak.GetKategorija().Naziv + " - " + sastojak.GetRoba().Naziv + " -> " + sastojak.Kolicina + "\n";
                        i++;
                    }

                    recept += "\n\n\nKORACI:\n";
                    foreach(Korak korak in proizvod.GetKoraci())
                    {
                        recept += korak.Redni_broj + ". korak: " + korak.Opis + "\n";
                    }

                    iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("RECEPT");
                    p.Alignment = Element.ALIGN_CENTER;
                    doc.Add(p);

                    doc.Add(new iTextSharp.text.Paragraph(50, " "));
                    doc.Add(new iTextSharp.text.Paragraph(recept));
                    string path = Directory.GetCurrentDirectory() + "\\" + fileName;
                    Process.Start(path);
                    
                    return false;
                }
                catch
                {
                    return true;
                }
            }
        }
    }
}
