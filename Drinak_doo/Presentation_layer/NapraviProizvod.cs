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
    public partial class NapraviProizvod : Form
    {
        Radnik radnik;
        List<Proizvod> proizvodi;

        public NapraviProizvod(Radnik radnik)
        {
            InitializeComponent();
            this.radnik = radnik;
            SetProizvodi();
        }

        private void SetProizvodi()
        {
            ProizvodiBusiness PB = new ProizvodiBusiness();
            proizvodi = PB.GetProizvodi();

            foreach(Proizvod proizvod in proizvodi)
            {
                cbProizvodi.Items.Add(proizvod.Naziv);
            }
        }

        private void btnNapravi_Click(object sender, EventArgs e)
        {
            if (cbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo odaberite proizvod!");
                return;
            }

            string napomena = tbNapomena.Text;
            if (napomena.Equals(""))
            {
                napomena = "Napomena nije dostupna!";
            }

            PravljenjaBusiness PB = new PravljenjaBusiness();
            int rbr = GetRbr(radnik.Id_radnik, proizvodi[cbProizvodi.SelectedIndex].Id_proizvod, DateTime.Now.ToString("dd-MMM-yy"));

            MessageBox.Show(PB.InsertPravljenje(new Pravljenje(radnik, proizvodi[cbProizvodi.SelectedIndex], rbr, DateTime.Now.ToString("dd-MMM-yy"), napomena)));
        }

        public int GetRbr(int id_radnik, int id_proizvod, string date)
        {
            int brojac = 0;

            PravljenjaBusiness PB = new PravljenjaBusiness();
            List<Pravljenje> pravljenja = PB.GetPravljenja();

            foreach(Pravljenje pravljenje in pravljenja)
            {
                if(pravljenje.GetNapravio().Id_radnik == id_radnik && pravljenje.GetNapravljen().Id_proizvod == id_proizvod && pravljenje.Datum.Trim().Equals(date))
                {
                    brojac++;
                }
            }

            return brojac+1;
        }
    }
}
