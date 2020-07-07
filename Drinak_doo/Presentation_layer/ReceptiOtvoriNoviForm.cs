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
            foreach(Sastojak sastojak in p.GetSastojci())
            {
                lbSviSastojci.Items.Add(sastojak.GetKategorija().Naziv + " - " + sastojak.GetRoba().Naziv);
            }
        }

        private void SetKoraci()
        {
            foreach(Korak korak in p.GetKoraci())
            {
                lbKoraci.Items.Add(korak.Redni_broj + ". korak");
            }
        }

        private void lbKoraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKoraci.SelectedIndex == -1)
                return;

            tbOpisKoraka.Text = p.GetKoraci()[lbKoraci.SelectedIndex].Redni_broj + ". korak: " + p.GetKoraci()[lbKoraci.SelectedIndex].Opis;
        }

        private void SetKategorije()
        {
            foreach(Sastojak sastojak in p.GetSastojci())
            {
                if (!cbKategorije.Items.Contains(sastojak.GetKategorija().Naziv))
                {
                    cbKategorije.Items.Add(sastojak.GetKategorija().Naziv);
                }
            }
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorije.SelectedIndex == -1)
                return;

            sastojciIzKategorije = new List<Sastojak>();
            lbKategorije.Items.Clear();

            foreach(Sastojak sastojak in p.GetSastojci())
            {
                if (sastojak.GetKategorija().Naziv.Equals(cbKategorije.SelectedItem))
                {
                    lbKategorije.Items.Add(sastojak.GetRoba().Naziv);
                    sastojciIzKategorije.Add(sastojak);
                }
            }
        }

        private void lbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKategorije.SelectedIndex == -1)
                return;

            lblKolicina.Text = sastojciIzKategorije[lbKategorije.SelectedIndex].Kolicina.ToString() + " "
                             + sastojciIzKategorije[lbKategorije.SelectedIndex].GetRoba().GetJM().Naziv;
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
