using Business_layer;
using Data_layer.models;
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
    public partial class RadniciForm : Form
    {
        private List<Radnik> radnici;
        private List<Pozicija> pozicije;
        public RadniciForm()
        {
            InitializeComponent();
            SetRadnici();
            SetPozicije();
        }

        private void SetRadnici()
        {
            RadniciBusiness RB = new RadniciBusiness();
            radnici = RB.GetRadnici();

            foreach (Radnik radnik in radnici)
            {
                lbRadnici.Items.Add(radnik.Ime + " " + radnik.Prezime + " - " + radnik.Poz.Naziv);
            }
        }

        private void SetPozicije()
        {
            PozicijeBusiness PB = new PozicijeBusiness();
            pozicije = PB.GetPozicije();

            foreach (Pozicija pozicija in pozicije)
            {
                cbPozicija.Items.Add(pozicija.Naziv);
            }
        }

        private void lbRadnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbIme.Text = radnici[lbRadnici.SelectedIndex].Ime;
            tbPrezime.Text = radnici[lbRadnici.SelectedIndex].Prezime;
            tbTelefon.Text = radnici[lbRadnici.SelectedIndex].Telefon;
            tbAdresa.Text = radnici[lbRadnici.SelectedIndex].Adresa;
            tbJmbg.Text = radnici[lbRadnici.SelectedIndex].Jmbg;

            cbPozicija.SelectedIndex = cbPozicija.Items.IndexOf(radnici[lbRadnici.SelectedIndex].Poz.Naziv);

            lblFunction.Text = radnici[lbRadnici.SelectedIndex].FunctionString;
            lblProcedure.Text = radnici[lbRadnici.SelectedIndex].ProcedureString;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text.Equals("") || tbPrezime.Text.Equals("") || tbTelefon.Text.Equals("") || tbAdresa.Text.Equals("") || tbJmbg.Text.Equals("") || cbPozicija.SelectedIndex == -1)
            {
                    MessageBox.Show("Popunite sva polja!");
                return;
            }

            RadniciBusiness RB = new RadniciBusiness();
            MessageBox.Show(RB.UpdateRadnik(new Radnik(radnici[lbRadnici.SelectedIndex].Id_radnik,
                                       tbIme.Text,
                                       tbPrezime.Text,
                                       tbTelefon.Text,
                                       tbAdresa.Text,
                                       tbJmbg.Text,
                                       pozicije[cbPozicija.SelectedIndex]
                                       )));
        }
    }
}
