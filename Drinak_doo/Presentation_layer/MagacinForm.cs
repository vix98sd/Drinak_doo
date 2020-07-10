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
    public partial class MagacinForm : Form
    {
        List<Magacin> roba;
        List<JedinicaMere> jm;
        public MagacinForm()
        {
            InitializeComponent();
            SetRobu();
            SetJM();
        }

        private void SetRobu()
        {
            roba = new MagacinBusiness().GetRobu();
            lbRoba.Items.Clear();
            tbNaziv.Text = "";
            tbKolicina.Text = "";
            cbJM.SelectedIndex = -1;
            nudKolicina.Value = 0;

            foreach(Magacin r in roba)
            {
                lbRoba.Items.Add(r.Naziv);
            }

            lbRoba.Items.Add("Dodaj novu robu u magacin");
        }

        public void SetJM()
        {
            jm = new JediniceMereBusiness().GetJediniceMere();

            foreach(JedinicaMere jmere in jm)
            {
                cbJM.Items.Add(jmere.Naziv);
            }
        }

        private void lbRoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRoba.SelectedIndex == -1) return;

            if(lbRoba.SelectedIndex == roba.Count)
            {
                rbDodaj.Checked = true;
                rbDodaj.Enabled = false;
                rbSkini.Enabled = false;

                tbNaziv.Text = "";
                tbKolicina.Text = "";
                cbJM.SelectedIndex = -1;
                nudKolicina.Value = 0;
            }
            else
            {
                rbDodaj.Enabled = true;
                rbSkini.Enabled = true;

                tbNaziv.Text = roba[lbRoba.SelectedIndex].Naziv;
                tbKolicina.Text = roba[lbRoba.SelectedIndex].Kolicina.ToString();
                
                for(int i = 0; i < cbJM.Items.Count; i++)
                {
                    if (cbJM.Items[i].Equals(roba[lbRoba.SelectedIndex].GetJM().Naziv))
                    {
                        cbJM.SelectedIndex = i;
                    }
                }

                nudKolicina.Value = 0;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(tbNaziv.Equals("") || tbKolicina.Equals("") || lbRoba.SelectedIndex == -1 || cbJM.SelectedIndex == -1)
            {
                MessageBox.Show("Popuninite sva polja i izaberite robu sa liste!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da sacuvate?", "Potvrda", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;


            if (lbRoba.SelectedIndex == roba.Count)
            {
                MessageBox.Show(
                                    new MagacinBusiness().InsertRobu(new Magacin(-1, tbNaziv.Text, Convert.ToDouble(nudKolicina.Value), jm[cbJM.SelectedIndex].Id_jm))
                                );
            }
            else
            {
                if (rbDodaj.Checked == true)
                    roba[lbRoba.SelectedIndex].Kolicina += Convert.ToDouble(nudKolicina.Value);
                else
                    roba[lbRoba.SelectedIndex].Kolicina -= Convert.ToDouble(nudKolicina.Value);

                MessageBox.Show(
                                    new MagacinBusiness().UpdateMagacin(new Magacin(roba[lbRoba.SelectedIndex].Id_robe, tbNaziv.Text, roba[lbRoba.SelectedIndex].Kolicina, jm[cbJM.SelectedIndex].Id_jm))
                                );
            }

            SetRobu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(lbRoba.SelectedIndex == -1 || lbRoba.SelectedIndex == roba.Count)
            {
                MessageBox.Show("Prvo izaberite robu sa liste!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete " + roba[lbRoba.SelectedIndex].Naziv + "?", "Potvrda", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            MessageBox.Show(
                                new MagacinBusiness().DeleteRobu(roba[lbRoba.SelectedIndex])
                            );

            SetRobu();
        }
    }
}
