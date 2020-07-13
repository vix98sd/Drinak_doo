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
    public partial class ReceptiMenu : Form
    {
        Radnik radnik;
        List<Proizvod> proizvodi;
        public ReceptiMenu(Radnik radnik)
        {
            InitializeComponent();
            this.radnik = radnik;
            SetForm();
            SetProizvode();
        }

        public void SetForm()
        {
            if(new RadniciBusiness().IsNotManager(radnik))
            {
                btnObrisi.Enabled = false;
                btnObrisiProizvod.Enabled = false;
                btnNovi.Enabled = false;
            }
        }

        public void SetProizvode()
        {
            ProizvodiBusiness PB = new ProizvodiBusiness();
            proizvodi = PB.GetProizvodi();

            lbProizvodi.Items.Clear();

            foreach(Proizvod proizvod in proizvodi)
            {
                lbProizvodi.Items.Add(proizvod.Naziv);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (lbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite proizvod!");
                return;
            }

            if (proizvodi[lbProizvodi.SelectedIndex].GetKoraci().Count != 0 || proizvodi[lbProizvodi.SelectedIndex].GetSastojci().Count != 0)
            {
                MessageBox.Show("Za ovaj proizvod vec postoji recept!");
                return;
            }

            Form dodajNovi = new ReceptiNoviForm(proizvodi[lbProizvodi.SelectedIndex]);
            this.Hide();
            dodajNovi.ShowDialog();
            this.Show();
            SetProizvode();
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            if(lbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite proizvod!");
                return;
            }

            if(proizvodi[lbProizvodi.SelectedIndex].GetKoraci().Count == 0 && proizvodi[lbProizvodi.SelectedIndex].GetSastojci().Count == 0)
            {
                MessageBox.Show("Ovaj proizvod nema sastavljen recept!");
                return;
            }

            Form otvoriRecept = new ReceptiOtvoriNoviForm(proizvodi[lbProizvodi.SelectedIndex], radnik);
            this.Hide();
            otvoriRecept.ShowDialog();
            this.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite proizvod!");
                return;
            }

            if (proizvodi[lbProizvodi.SelectedIndex].GetKoraci().Count == 0 && proizvodi[lbProizvodi.SelectedIndex].GetSastojci().Count == 0)
            {
                MessageBox.Show("Ovaj proizvod nema sastavljen recept!");
                return;
            }


            MessageBox.Show(
                                new ProizvodiBusiness().DeleteRecept(proizvodi[lbProizvodi.SelectedIndex].Id_proizvod)
                            );

            SetProizvode();
        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            if(lbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite proizvod!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete ovaj proizvod?\nSva pravljenja ce takodje biti obrisana!", "Potvrda", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                                    new ProizvodiBusiness().DeleteProizvod(proizvodi[lbProizvodi.SelectedIndex].Id_proizvod)
                                );
            }

            SetProizvode();
        }
    }
}
