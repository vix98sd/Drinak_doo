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

        public NapravljeniProizvodi()
        {
            InitializeComponent();
            SetDatume();
            SetPravljenja();
        }

        private void SetDatume()
        {
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
                SetPravljenja();
            }else if(cbDatum.SelectedIndex != -1)
            {
                lbNapravljeni.Items.Clear();
                filtriranaPravljenja = new List<Pravljenje>();

                foreach(Pravljenje pravljenje in pravljenja)
                {
                    if (pravljenje.Datum.Equals(cbDatum.SelectedItem))
                    {
                        lbNapravljeni.Items.Add(pravljenje.Datum + "- " + pravljenje.GetNapravljen().Naziv + " - " + pravljenje.GetNapravio().Ime + " " + pravljenje.GetNapravio().Prezime);
                        filtriranaPravljenja.Add(pravljenje);
                    }
                }
            }
        }

        private void SetPravljenja()
        {
            PravljenjaBusiness PB = new PravljenjaBusiness();
            pravljenja = PB.GetPravljenja();

            lbNapravljeni.Items.Clear();
            filtriranaPravljenja = new List<Pravljenje>();

            foreach(Pravljenje pravljenje in pravljenja)
            {
                lbNapravljeni.Items.Add(pravljenje.Datum + "- " + pravljenje.GetNapravljen().Naziv + " - " + pravljenje.GetNapravio().Ime + " " + pravljenje.GetNapravio().Prezime);
                filtriranaPravljenja.Add(pravljenje);
            }
        }

        private void lbNapravljeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNapravljeni.SelectedIndex == -1)
                return;

            tbNapomena.Text = filtriranaPravljenja[lbNapravljeni.SelectedIndex].Napomena;
        }
    }
}
