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

            this.Close();
        }

        public int GetRbr(int id_radnik, int id_proizvod, string date)
        {
            return new PravljenjaBusiness().GetTodaysRbr(id_radnik, id_proizvod, date);
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {
            if(cbProizvodi.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite proizvod!");
                return;
            }

            if(proizvodi[cbProizvodi.SelectedIndex].GetKoraci().Count == 0 && proizvodi[cbProizvodi.SelectedIndex].GetSastojci().Count == 0)
            {
                MessageBox.Show("Ovaj proizvod nema sastavljen recept!");
                return;
            }

            Form otvoriRecept = new ReceptiOtvoriNoviForm(proizvodi[cbProizvodi.SelectedIndex]);

            otvoriRecept.ShowDialog();
        }
    }
}
