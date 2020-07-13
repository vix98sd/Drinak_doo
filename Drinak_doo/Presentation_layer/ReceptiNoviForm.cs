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
    public partial class ReceptiNoviForm : Form
    {
        Proizvod p;
        List<Kategorija> kategorije;
        List<Sastojak> sastojciIzKategorije;
        List<Magacin> magacin;
        Korak noviKorak;
        bool noviRecept;

        public ReceptiNoviForm()
        {
            InitializeComponent();
            noviRecept = true;
            p = new Proizvod();
            SetNoveKategorije();
        }

        public ReceptiNoviForm(Proizvod proizvod)
        {
            InitializeComponent();
            noviRecept = false;
            p = proizvod;
            SetUpAll();
        }

        private void SetUpAll()
        {
            tbNaziv.Text = p.Naziv;
            tbTezina.Text = p.Tezina.ToString();
            tbCena.Text = p.Cena.ToString();
            tbNapomena.Text = p.Napomena;

            SetSastojci();
            SetKoraci();
            SetKategorije();
            SetNoveKategorije();
            SetRoba();
        }

        private void SetSastojci()
        {
            lbSviSastojci.Items.Clear();
            foreach (Sastojak sastojak in p.GetSastojci())
            {
                lbSviSastojci.Items.Add(sastojak.GetKategorija().Naziv + " - " + sastojak.GetRoba().Naziv);
            }
        }

        public void SetRoba()
        {
            MagacinBusiness MB = new MagacinBusiness();
            magacin = MB.GetRobu();

            foreach(Magacin roba in magacin)
            {
                cbNoviSastojak.Items.Add(roba.Naziv);
            }
        }

        private void SetKoraci()
        {
            lbKoraci.Items.Clear();
            foreach (Korak korak in p.GetKoraci())
            {
                lbKoraci.Items.Add(korak.Redni_broj + ". korak");
            }
        }

        private void lbKoraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKoraci.SelectedIndex == -1)
                return;

            tbOpisKoraka.Text = p.GetKoraci()[lbKoraci.SelectedIndex].Opis;
        }

        private void SetKategorije()
        {
            cbKategorije.Items.Clear();

            foreach (Sastojak sastojak in p.GetSastojci())
            {
                if (!cbKategorije.Items.Contains(sastojak.GetKategorija().Naziv))
                {
                    cbKategorije.Items.Add(sastojak.GetKategorija().Naziv);
                }
            }
        }

        private void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategorije.SelectedIndex == -1)
                return;

            sastojciIzKategorije = new List<Sastojak>();
            lbKategorije.Items.Clear();

            foreach (Sastojak sastojak in p.GetSastojci())
            {
                if (sastojak.GetKategorija().Naziv.Equals(cbKategorije.SelectedItem))
                {
                    lbKategorije.Items.Add(sastojak.GetRoba().Naziv);
                    sastojciIzKategorije.Add(sastojak);
                }
            }
        }

        private void lbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKategorije.SelectedIndex == -1)
                return;

            tbKolicinaSastojka.Text = sastojciIzKategorije[lbKategorije.SelectedIndex].Kolicina.ToString();
        }

        private void btnNoviKorak_Click(object sender, EventArgs e)
        {
            if (tbOpisKoraka.Text.Equals("") && lbKoraci.Items.Count > 0)
            {
                MessageBox.Show("Pre nego sto dodate novi korak, popunite opis ovog i sacuvajte ga!");
                return;
            }

            noviKorak = new Korak(p.Id_proizvod, p.GetKoraci().Count + 1, "");
            p.GetKoraci().Add(noviKorak);
            SetKoraci();
            lbKoraci.SetSelected(lbKoraci.Items.Count-1, true);
        }

        private void btnOpis_Click(object sender, EventArgs e)
        {
            if(lbKoraci.SelectedIndex == -1)
            {
                MessageBox.Show("Prvo izaberite korak, ili dodajte novi!");
                return;
            }

            KoraciBusiness KB = new KoraciBusiness();

            if (p.GetKoraci()[lbKoraci.SelectedIndex].Opis.Equals(""))
            {
                noviKorak.Opis = tbOpisKoraka.Text;
                MessageBox.Show(KB.InsertKorak(noviKorak));
            }
            else
            {
                p.GetKoraci()[lbKoraci.SelectedIndex].Opis = tbOpisKoraka.Text;
                MessageBox.Show(KB.UpdateKorak(p.GetKoraci()[lbKoraci.SelectedIndex]));
            }

        }

        private void SetNoveKategorije()
        {
            KategorijeBusiness KB = new KategorijeBusiness();
            kategorije = KB.GetKategorije();

            foreach(Kategorija kategorija in kategorije)
            {
                cbNovaKategorija.Items.Add(kategorija.Naziv);
            }
        }

        private void btnNoviSastojak_Click(object sender, EventArgs e)
        {
            if(cbNovaKategorija.SelectedIndex == -1 || cbNoviSastojak.SelectedIndex == -1 || tbNoviSastojakKolicina.Text.Equals(""))
            {
                MessageBox.Show("Pre dodavanja morate izabrati sastojak i kategoriju, te upisati kolicinu!");
                return;
            }
            foreach(Sastojak sastojak in p.GetSastojci())
            {
                if (sastojak.GetRoba().Naziv.Equals(magacin[cbNoviSastojak.SelectedIndex].Naziv) 
                    && sastojak.GetKategorija().Naziv.Equals(kategorije[cbNovaKategorija.SelectedIndex].Naziv))
                {
                    MessageBox.Show("Ovaj sastojak vec postoji u ovoj kategoriji, proverite!");
                    return;
                }
            }

            SastojciBusiness SB = new SastojciBusiness();
            Sastojak noviSastojak = new Sastojak(p.Id_proizvod,
                                                           magacin[cbNoviSastojak.SelectedIndex].Id_robe,
                                                           kategorije[cbNovaKategorija.SelectedIndex].Id_kategorija,
                                                           Convert.ToDouble(tbNoviSastojakKolicina.Text));
            MessageBox.Show(SB.InsertSastojak( noviSastojak, tbTriggerName.Text));
            p.GetSastojci().Add(noviSastojak);

            SetKategorije();
            SetSastojci();
        }

        private void btnIzmeniSastojak_Click(object sender, EventArgs e)
        {
            if(cbKategorije.SelectedIndex == -1 || lbKategorije.SelectedIndex == -1 || tbKolicinaSastojka.Text.Equals(""))
            {
                MessageBox.Show("Morate da izaberete proizvod i sastojak za izmenu, kao i da upisete kolicinu!");
                return;
            }

            SastojciBusiness SB = new SastojciBusiness();
            Sastojak azuriraniSastojak = new Sastojak(p.Id_proizvod,
                                                           sastojciIzKategorije[lbKategorije.SelectedIndex].GetRoba(),
                                                           sastojciIzKategorije[lbKategorije.SelectedIndex].GetKategorija(),
                                                           Convert.ToDouble(tbKolicinaSastojka.Text));
            MessageBox.Show(SB.UpdateSastojak(azuriraniSastojak));

            foreach(Sastojak sastojak in p.GetSastojci())
            {
                if(sastojak.Id_proizvod == azuriraniSastojak.Id_proizvod 
                    && sastojak.GetRoba().Id_robe == azuriraniSastojak.GetRoba().Id_robe 
                    && sastojak.GetKategorija().Id_kategorija == azuriraniSastojak.GetKategorija().Id_kategorija)
                {
                    sastojak.Kolicina = azuriraniSastojak.Kolicina;
                }
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if(tbNaziv.Text.Equals("")
                && tbTezina.Text.Equals("")
                && tbNapomena.Text.Equals("")
                && tbCena.Text.Equals(""))
            {
                MessageBox.Show("Morate popuniti sve podatke!");
                return;
            }

            ProizvodiBusiness PB = new ProizvodiBusiness();
            p.Naziv = tbNaziv.Text;
            p.Tezina = Convert.ToDouble(tbTezina.Text);
            p.Napomena = tbNapomena.Text;
            p.Cena = Convert.ToDouble(tbCena.Text);
            MessageBox.Show(PB.UpdateProizvod(p));
        }
    }
}
