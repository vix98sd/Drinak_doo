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
    public partial class NapravljeniProizvodi : Form
    {
        List<String> datumi;
        List<Pravljenje> pravljenja;
        List<Pravljenje> filtriranaPravljenja;
        Radnik radnik;

        public NapravljeniProizvodi(Radnik radnik)
        {
            InitializeComponent();
            this.radnik = radnik;
            SetDatume();
            SetPravljenja();
        }

        private void SetDatume()
        {
            if(!radnik.Poz.Naziv.Equals("Vlasnik") && !radnik.Poz.Naziv.Equals("Manager") && !radnik.Poz.Naziv.Equals("Sef smene"))
            {
                cbDatum.Items.Clear();
                cbDatum.Items.Add(DateTime.Now.ToString("dd-MMM-yy"));
                return;
            }

            PravljenjaBusiness PB = new PravljenjaBusiness();
            datumi = PB.GetDatume();

            foreach(String datum in datumi)
            {
                cbDatum.Items.Add(datum);
            }
        }

        private void cbDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDatum.SelectedItem.Equals("Svi"))
            {
                lbNapravljeni.Items.Clear();
                filtriranaPravljenja = new List<Pravljenje>();

                foreach(Pravljenje pravljenje in pravljenja)
                {
                    lbNapravljeni.Items.Add(pravljenje.Datum + " - " + pravljenje.GetNapravljen().Naziv + " - " + pravljenje.GetNapravio().Ime + " " + pravljenje.GetNapravio().Prezime);
                    filtriranaPravljenja.Add(pravljenje);
                }
            }
            else if(cbDatum.SelectedIndex != -1)
            {
                lbNapravljeni.Items.Clear();
                filtriranaPravljenja = new List<Pravljenje>();

                foreach(Pravljenje pravljenje in pravljenja)
                {
                    if (pravljenje.Datum.Equals(cbDatum.SelectedItem))
                    {
                        lbNapravljeni.Items.Add(pravljenje.Datum + " - " + pravljenje.GetNapravljen().Naziv + " - " + pravljenje.GetNapravio().Ime + " " + pravljenje.GetNapravio().Prezime);
                        filtriranaPravljenja.Add(pravljenje);
                    }
                }
            }
        }

        private void SetPravljenja()
        {
            PravljenjaBusiness PB = new PravljenjaBusiness();
            pravljenja = PB.GetPravljenja();

            cbDatum.SelectedIndex = 0;
        }
        

        private void lbNapravljeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNapravljeni.SelectedIndex == -1)
                return;

            tbNapomena.Text = filtriranaPravljenja[lbNapravljeni.SelectedIndex].Napomena;
        }
    }
}
