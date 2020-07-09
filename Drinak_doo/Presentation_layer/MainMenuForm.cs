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
    public partial class MainMenuForm : Form
    {
        private Radnik radnik;
        public MainMenuForm(Radnik radnik)
        {
            InitializeComponent();
            this.radnik = radnik;
            SetHierarchy();
            SetContent();
            timerDT.Start();
        }

        private void btnSviRadnici_Click(object sender, EventArgs e)
        {
            Form radniciForm = new RadniciForm();
            this.Hide();
            radniciForm.ShowDialog();
            this.Show();
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            Form napravljeniProizvodi = new NapravljeniProizvodi(radnik);
            this.Hide();
            napravljeniProizvodi.ShowDialog();
            this.Show();
        }

        private void btnRecepti_Click(object sender, EventArgs e)
        {
            Form receptiMenu = new ReceptiMenu(radnik);
            this.Hide();
            receptiMenu.ShowDialog();
            this.Show();
        }

        private void btnNoviProizvod_Click(object sender, EventArgs e)
        {
            Form noviProizvod = new NoviProizvodForm();
            this.Hide();
            noviProizvod.ShowDialog();
            this.Show();
        }

        private void btnNapravi_Click(object sender, EventArgs e)
        {
            Form napraviProizvod = new NapraviProizvod(radnik);
            this.Hide();
            napraviProizvod.ShowDialog();
            this.Show();
        }

        private void SetHierarchy()
        {
            if(new RadniciBusiness().IsNotManager(radnik))
            {
                btnSviRadnici.Enabled = false;
                btnSviRadnici.Visible = false;

                btnNoviProizvod.Enabled = false;
                btnNoviProizvod.Visible = false;

                btnMagacin.Enabled = false;
                btnMagacin.Visible = false;
            }
        }

        private void SetContent()
        {
            lblIme.Text = radnik.Ime + " " + radnik.Prezime;
            lblPozicija.Text = "- " + radnik.Poz.Naziv;
        }

        private void timerDT_Tick(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToString("dd-MMM-yy");
            lblVreme.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnMagacin_Click(object sender, EventArgs e)
        {
            Form magacin = new MagacinForm();
            this.Hide();
            magacin.ShowDialog();
            this.Show();
        }
    }
}
