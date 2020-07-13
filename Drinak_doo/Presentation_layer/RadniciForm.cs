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

            lbRadnici.Items.Clear();

            foreach (Radnik radnik in radnici)
            {
                lbRadnici.Items.Add(radnik.Ime + " " + radnik.Prezime + " - " + radnik.Poz.Naziv);
            }

            lbRadnici.Items.Add("Dodaj novog radnika!");
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
            if (lbRadnici.SelectedIndex == -1)
                return;

            if(!lbRadnici.SelectedItem.Equals("Dodaj novog radnika!"))
            {
                btnObrisi.Enabled = true;

                btnAzuriraj.Text = "Azuriraj";
                tbIme.Text = radnici[lbRadnici.SelectedIndex].Ime;
                tbPrezime.Text = radnici[lbRadnici.SelectedIndex].Prezime;
                tbTelefon.Text = radnici[lbRadnici.SelectedIndex].Telefon;
                tbAdresa.Text = radnici[lbRadnici.SelectedIndex].Adresa;
                tbJmbg.Text = radnici[lbRadnici.SelectedIndex].Jmbg;

                cbPozicija.SelectedIndex = cbPozicija.Items.IndexOf(radnici[lbRadnici.SelectedIndex].Poz.Naziv);

                lblFunction.Text = radnici[lbRadnici.SelectedIndex].FunctionString;
                lblProcedure.Text = radnici[lbRadnici.SelectedIndex].ProcedureString;
            }
            else
            {
                btnObrisi.Enabled = false;

                btnAzuriraj.Text = "Dodaj";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbTelefon.Text = "";
                tbAdresa.Text = "";
                tbJmbg.Text = "";

                cbPozicija.SelectedIndex = -1;
                lblFunction.Text = "-";
                lblProcedure.Text = "-";
            }

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (tbIme.Text.Equals("") || tbPrezime.Text.Equals("") || tbTelefon.Text.Equals("") || tbAdresa.Text.Equals("") || tbJmbg.Text.Equals("") || cbPozicija.SelectedIndex == -1 || lbRadnici.SelectedIndex == -1)
            {
                    MessageBox.Show("Popunite sva polja ili izaberite radnika za izmenu!");
                return;
            }

            if(btnAzuriraj.Text.Equals("Azuriraj"))
            {
                MessageBox.Show(
                    new RadniciBusiness().UpdateRadnik(new Radnik(radnici[lbRadnici.SelectedIndex].Id_radnik,
                                                                  tbIme.Text,
                                                                  tbPrezime.Text,
                                                                  tbTelefon.Text,
                                                                  tbAdresa.Text,
                                                                  tbJmbg.Text,
                                                                  pozicije[cbPozicija.SelectedIndex]))
                                );
            }
            else
            {
                MessageBox.Show(
                                new RadniciBusiness().InsertRadnik(new Radnik(FindID(),
                                                                              tbIme.Text,
                                                                              tbPrezime.Text,
                                                                              tbTelefon.Text,
                                                                              tbAdresa.Text,
                                                                              tbJmbg.Text,
                                                                              pozicije[cbPozicija.SelectedIndex]))
                                );
                SetRadnici();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbRadnici.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite radnika!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati " + radnici[lbRadnici.SelectedIndex].Ime + " " + radnici[lbRadnici.SelectedIndex].Prezime, "Potvrda", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(new RadniciBusiness().DeleteRadnik(radnici[lbRadnici.SelectedIndex].Id_radnik));
                SetRadnici();
            }
        }

        private int FindID()
        {
            int id = -1;

            foreach(Radnik radnik in radnici)
            {
                if(radnik.Id_radnik > id)
                {
                    id = radnik.Id_radnik;
                }
            }

            return id + 1;
        }

        
    }
}
