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
    public partial class LogInForm : Form
    {
        List<Radnik> radnici;
        
        public LogInForm()
        {
            InitializeComponent();
            SetRadnici();
        }

        private void SetRadnici()
        {
            RadniciBusiness RB = new RadniciBusiness();
            radnici = RB.GetRadnici();

            foreach(Radnik radnik in radnici)
                cbRadnici.Items.Add(radnik.Ime + " " + radnik.Prezime);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /*if (cbRadnici.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati radnika!");
                return;
            }

            if (!tbJMBG.Text.Equals(radnici[cbRadnici.SelectedIndex].Jmbg))
            {
                MessageBox.Show("Niste uneli dobru lozinku!");
                return;
            }*/

            MainMenuForm mainMenu = new MainMenuForm(radnici[cbRadnici.SelectedIndex]);
            this.Hide();
            mainMenu.ShowDialog();
            this.Show();
        }
    }
}
