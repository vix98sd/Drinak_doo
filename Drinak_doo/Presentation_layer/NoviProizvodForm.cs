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
    public partial class NoviProizvodForm : Form
    {
        public NoviProizvodForm()
        {
            InitializeComponent();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if(tbNaziv.Text.Equals("") ||
               tbTezina.Text.Equals("") ||
               tbNapomena.Text.Equals("") ||
               tbCena.Text.Equals(""))
            {
                MessageBox.Show("Molimo popunite sva polja!");
                return;
            }

            ProizvodiBusiness PB = new ProizvodiBusiness();
            Proizvod proizvod = new Proizvod(PB.FreeID(), tbNaziv.Text, Convert.ToDouble(tbTezina.Text), Convert.ToDouble(tbCena.Text), tbNapomena.Text);
            MessageBox.Show(PB.InsertProizvod(proizvod));
        }
    }
}
