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
        List<Proizvod> proizvodi;
        public ReceptiMenu()
        {
            InitializeComponent();
            SetProizvode();
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

            if (proizvodi[lbProizvodi.SelectedIndex].Koraci.Count != 0 || proizvodi[lbProizvodi.SelectedIndex].Sastojci.Count != 0)
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

            if(proizvodi[lbProizvodi.SelectedIndex].Koraci.Count == 0 && proizvodi[lbProizvodi.SelectedIndex].Sastojci.Count == 0)
            {
                MessageBox.Show("Ovaj proizvod nema sastavljen recept!");
                return;
            }

            Form otvoriRecept = new ReceptiOtvoriNoviForm(proizvodi[lbProizvodi.SelectedIndex]);
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

            if (proizvodi[lbProizvodi.SelectedIndex].Koraci.Count == 0 && proizvodi[lbProizvodi.SelectedIndex].Sastojci.Count == 0)
            {
                MessageBox.Show("Ovaj proizvod nema sastavljen recept!");
                return;
            }

            SastojciBusiness SB = new SastojciBusiness();
            MessageBox.Show(SB.DeleteSastojke(proizvodi[lbProizvodi.SelectedIndex].Id_proizvod));

            KoraciBusiness KB = new KoraciBusiness();
            MessageBox.Show(KB.DeleteKorake(proizvodi[lbProizvodi.SelectedIndex].Id_proizvod));

            SetProizvode();
        }
    }
}
