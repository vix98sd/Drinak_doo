using Data_layer.models;
using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_layer
{
    public partial class ReceptiOtvoriNoviForm : Form
    {
        Proizvod p;
        List<Sastojak> sastojciIzKategorije;
        public ReceptiOtvoriNoviForm(Proizvod proizvod)
        {
            InitializeComponent();
            p = proizvod;
            SetUpAll();
        }

        private void SetUpAll()
        {
            lblNaziv.Text = p.Naziv;
            lblTezina.Text = p.Tezina.ToString() + "gr";
            lblCena.Text = p.Cena.ToString();
            tbNapomena.Text = p.Napomena;

            SetSastojci();
            SetKoraci();
            SetKategorije();
        }

        private void SetSastojci()
        {
            foreach(Sastojak sastojak in p.Sastojci)
            {
                lbSviSastojci.Items.Add(sastojak.Kategorija_sastojka.Naziv + " - " + sastojak.Roba.Naziv);
            }
        }

        private void SetKoraci()
        {
            foreach(Korak korak in p.Koraci)
            {
                lbKoraci.Items.Add(korak.Redni_broj + ". korak");
            }
        }

        private void lbKoraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKoraci.SelectedIndex == -1)
                return;

            tbOpisKoraka.Text = p.Koraci[lbKoraci.SelectedIndex].Redni_broj + ". korak: " + p.Koraci[lbKoraci.SelectedIndex].Opis;
        }

        private void SetKategorije()
        {
            foreach(Sastojak sastojak in p.Sastojci)
            {
                if (!cbKategorije.Items.Contains(sastojak.Kategorija_sastojka.Naziv))
                {
                    cbKategorije.Items.Add(sastojak.Kategorija_sastojka.Naziv);
                }
            }
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorije.SelectedIndex == -1)
                return;

            sastojciIzKategorije = new List<Sastojak>();
            lbKategorije.Items.Clear();

            foreach(Sastojak sastojak in p.Sastojci)
            {
                if (sastojak.Kategorija_sastojka.Naziv.Equals(cbKategorije.SelectedItem))
                {
                    lbKategorije.Items.Add(sastojak.Roba.Naziv);
                    sastojciIzKategorije.Add(sastojak);
                }
            }
        }

        private void lbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKategorije.SelectedIndex == -1)
                return;

            lblKolicina.Text = sastojciIzKategorije[lbKategorije.SelectedIndex].Kolicina.ToString() + " "
                             + sastojciIzKategorije[lbKategorije.SelectedIndex].Roba.Jm.Naziv;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form izmenaProizvoda = new ReceptiNoviForm(p);
            this.Hide();
            izmenaProizvoda.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
