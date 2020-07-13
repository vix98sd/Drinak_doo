namespace Presentation_layer
{
    partial class ReceptiNoviForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSviSastojci = new System.Windows.Forms.Label();
            this.lbSviSastojci = new System.Windows.Forms.ListBox();
            this.tbOpisKoraka = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblKoraci = new System.Windows.Forms.Label();
            this.lbKoraci = new System.Windows.Forms.ListBox();
            this.lblSastojci = new System.Windows.Forms.Label();
            this.lbKategorije = new System.Windows.Forms.ListBox();
            this.lblKategorije = new System.Windows.Forms.Label();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblCenaHC = new System.Windows.Forms.Label();
            this.lblTezinaHC = new System.Windows.Forms.Label();
            this.lblNazivHC = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.lblNovaKategorija = new System.Windows.Forms.Label();
            this.cbNovaKategorija = new System.Windows.Forms.ComboBox();
            this.btnIzmeniSastojak = new System.Windows.Forms.Button();
            this.lblNoviSastojak = new System.Windows.Forms.Label();
            this.cbNoviSastojak = new System.Windows.Forms.ComboBox();
            this.btnNoviKorak = new System.Windows.Forms.Button();
            this.btnOpis = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.tbKolicinaSastojka = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoviSastojakKolicina = new System.Windows.Forms.TextBox();
            this.btnNoviSastojak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTriggerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSviSastojci
            // 
            this.lblSviSastojci.AutoSize = true;
            this.lblSviSastojci.Location = new System.Drawing.Point(567, 21);
            this.lblSviSastojci.Name = "lblSviSastojci";
            this.lblSviSastojci.Size = new System.Drawing.Size(63, 13);
            this.lblSviSastojci.TabIndex = 56;
            this.lblSviSastojci.Text = "Svi sastojci:";
            // 
            // lbSviSastojci
            // 
            this.lbSviSastojci.FormattingEnabled = true;
            this.lbSviSastojci.Location = new System.Drawing.Point(570, 37);
            this.lbSviSastojci.Name = "lbSviSastojci";
            this.lbSviSastojci.Size = new System.Drawing.Size(207, 355);
            this.lbSviSastojci.TabIndex = 55;
            // 
            // tbOpisKoraka
            // 
            this.tbOpisKoraka.Location = new System.Drawing.Point(372, 295);
            this.tbOpisKoraka.Multiline = true;
            this.tbOpisKoraka.Name = "tbOpisKoraka";
            this.tbOpisKoraka.Size = new System.Drawing.Size(174, 95);
            this.tbOpisKoraka.TabIndex = 53;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(369, 279);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(67, 13);
            this.lblOpis.TabIndex = 52;
            this.lblOpis.Text = "Opis koraka:";
            // 
            // lblKoraci
            // 
            this.lblKoraci.AutoSize = true;
            this.lblKoraci.Location = new System.Drawing.Point(211, 279);
            this.lblKoraci.Name = "lblKoraci";
            this.lblKoraci.Size = new System.Drawing.Size(40, 13);
            this.lblKoraci.TabIndex = 51;
            this.lblKoraci.Text = "Koraci:";
            // 
            // lbKoraci
            // 
            this.lbKoraci.FormattingEnabled = true;
            this.lbKoraci.Location = new System.Drawing.Point(214, 295);
            this.lbKoraci.Name = "lbKoraci";
            this.lbKoraci.Size = new System.Drawing.Size(121, 95);
            this.lbKoraci.TabIndex = 50;
            this.lbKoraci.SelectedIndexChanged += new System.EventHandler(this.lbKoraci_SelectedIndexChanged);
            // 
            // lblSastojci
            // 
            this.lblSastojci.AutoSize = true;
            this.lblSastojci.Location = new System.Drawing.Point(422, 67);
            this.lblSastojci.Name = "lblSastojci";
            this.lblSastojci.Size = new System.Drawing.Size(127, 13);
            this.lblSastojci.TabIndex = 49;
            this.lblSastojci.Text = "Sastojci iz ove kategorije:";
            // 
            // lbKategorije
            // 
            this.lbKategorije.FormattingEnabled = true;
            this.lbKategorije.Location = new System.Drawing.Point(425, 83);
            this.lbKategorije.Name = "lbKategorije";
            this.lbKategorije.Size = new System.Drawing.Size(121, 121);
            this.lbKategorije.TabIndex = 48;
            this.lbKategorije.SelectedIndexChanged += new System.EventHandler(this.lbKategorije_SelectedIndexChanged);
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Location = new System.Drawing.Point(422, 19);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(105, 13);
            this.lblKategorije.TabIndex = 47;
            this.lblKategorije.Text = "Kategorije sastojaka:";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(425, 37);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbKategorije.TabIndex = 46;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(29, 135);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(123, 71);
            this.tbNapomena.TabIndex = 45;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(27, 119);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 44;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblCenaHC
            // 
            this.lblCenaHC.AutoSize = true;
            this.lblCenaHC.Location = new System.Drawing.Point(27, 354);
            this.lblCenaHC.Name = "lblCenaHC";
            this.lblCenaHC.Size = new System.Drawing.Size(35, 13);
            this.lblCenaHC.TabIndex = 42;
            this.lblCenaHC.Text = "Cena:";
            // 
            // lblTezinaHC
            // 
            this.lblTezinaHC.AutoSize = true;
            this.lblTezinaHC.Location = new System.Drawing.Point(28, 70);
            this.lblTezinaHC.Name = "lblTezinaHC";
            this.lblTezinaHC.Size = new System.Drawing.Size(42, 13);
            this.lblTezinaHC.TabIndex = 40;
            this.lblTezinaHC.Text = "Tezina:";
            // 
            // lblNazivHC
            // 
            this.lblNazivHC.AutoSize = true;
            this.lblNazivHC.Location = new System.Drawing.Point(27, 21);
            this.lblNazivHC.Name = "lblNazivHC";
            this.lblNazivHC.Size = new System.Drawing.Size(64, 13);
            this.lblNazivHC.TabIndex = 38;
            this.lblNazivHC.Text = "Naziv torte: ";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(30, 37);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(122, 20);
            this.tbNaziv.TabIndex = 57;
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(30, 86);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(122, 20);
            this.tbTezina.TabIndex = 58;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(30, 370);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(122, 20);
            this.tbCena.TabIndex = 59;
            // 
            // lblNovaKategorija
            // 
            this.lblNovaKategorija.AutoSize = true;
            this.lblNovaKategorija.Location = new System.Drawing.Point(287, 19);
            this.lblNovaKategorija.Name = "lblNovaKategorija";
            this.lblNovaKategorija.Size = new System.Drawing.Size(90, 13);
            this.lblNovaKategorija.TabIndex = 61;
            this.lblNovaKategorija.Text = "Izaberi kategoriju:";
            // 
            // cbNovaKategorija
            // 
            this.cbNovaKategorija.FormattingEnabled = true;
            this.cbNovaKategorija.Location = new System.Drawing.Point(290, 37);
            this.cbNovaKategorija.Name = "cbNovaKategorija";
            this.cbNovaKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbNovaKategorija.TabIndex = 60;
            // 
            // btnIzmeniSastojak
            // 
            this.btnIzmeniSastojak.Location = new System.Drawing.Point(425, 249);
            this.btnIzmeniSastojak.Name = "btnIzmeniSastojak";
            this.btnIzmeniSastojak.Size = new System.Drawing.Size(121, 23);
            this.btnIzmeniSastojak.TabIndex = 65;
            this.btnIzmeniSastojak.Text = "Izmeni sastojak";
            this.btnIzmeniSastojak.UseVisualStyleBackColor = true;
            this.btnIzmeniSastojak.Click += new System.EventHandler(this.btnIzmeniSastojak_Click);
            // 
            // lblNoviSastojak
            // 
            this.lblNoviSastojak.AutoSize = true;
            this.lblNoviSastojak.Location = new System.Drawing.Point(287, 69);
            this.lblNoviSastojak.Name = "lblNoviSastojak";
            this.lblNoviSastojak.Size = new System.Drawing.Size(128, 13);
            this.lblNoviSastojak.TabIndex = 64;
            this.lblNoviSastojak.Text = "Novi sastojak u kategoriji:";
            // 
            // cbNoviSastojak
            // 
            this.cbNoviSastojak.FormattingEnabled = true;
            this.cbNoviSastojak.Location = new System.Drawing.Point(290, 87);
            this.cbNoviSastojak.Name = "cbNoviSastojak";
            this.cbNoviSastojak.Size = new System.Drawing.Size(121, 21);
            this.cbNoviSastojak.TabIndex = 63;
            // 
            // btnNoviKorak
            // 
            this.btnNoviKorak.Location = new System.Drawing.Point(214, 406);
            this.btnNoviKorak.Name = "btnNoviKorak";
            this.btnNoviKorak.Size = new System.Drawing.Size(121, 23);
            this.btnNoviKorak.TabIndex = 66;
            this.btnNoviKorak.Text = "Novi korak";
            this.btnNoviKorak.UseVisualStyleBackColor = true;
            this.btnNoviKorak.Click += new System.EventHandler(this.btnNoviKorak_Click);
            // 
            // btnOpis
            // 
            this.btnOpis.Location = new System.Drawing.Point(372, 404);
            this.btnOpis.Name = "btnOpis";
            this.btnOpis.Size = new System.Drawing.Size(174, 23);
            this.btnOpis.TabIndex = 67;
            this.btnOpis.Text = "Sacuvaj opis";
            this.btnOpis.UseVisualStyleBackColor = true;
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(29, 405);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(123, 23);
            this.btnSaveAll.TabIndex = 68;
            this.btnSaveAll.Text = "Sacuvaj promene";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // tbKolicinaSastojka
            // 
            this.tbKolicinaSastojka.Location = new System.Drawing.Point(425, 223);
            this.tbKolicinaSastojka.Name = "tbKolicinaSastojka";
            this.tbKolicinaSastojka.Size = new System.Drawing.Size(121, 20);
            this.tbKolicinaSastojka.TabIndex = 69;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(423, 207);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 70;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Kolicina novog sastojka:";
            // 
            // tbNoviSastojakKolicina
            // 
            this.tbNoviSastojakKolicina.Location = new System.Drawing.Point(290, 135);
            this.tbNoviSastojakKolicina.Name = "tbNoviSastojakKolicina";
            this.tbNoviSastojakKolicina.Size = new System.Drawing.Size(121, 20);
            this.tbNoviSastojakKolicina.TabIndex = 72;
            // 
            // btnNoviSastojak
            // 
            this.btnNoviSastojak.Location = new System.Drawing.Point(317, 215);
            this.btnNoviSastojak.Name = "btnNoviSastojak";
            this.btnNoviSastojak.Size = new System.Drawing.Size(63, 23);
            this.btnNoviSastojak.TabIndex = 71;
            this.btnNoviSastojak.Text = "Dodaj";
            this.btnNoviSastojak.UseVisualStyleBackColor = true;
            this.btnNoviSastojak.Click += new System.EventHandler(this.btnNoviSastojak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Naziv za triger test:";
            // 
            // tbTriggerName
            // 
            this.tbTriggerName.Location = new System.Drawing.Point(291, 183);
            this.tbTriggerName.Name = "tbTriggerName";
            this.tbTriggerName.Size = new System.Drawing.Size(121, 20);
            this.tbTriggerName.TabIndex = 74;
            // 
            // ReceptiNoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTriggerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoviSastojakKolicina);
            this.Controls.Add(this.btnNoviSastojak);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.tbKolicinaSastojka);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnOpis);
            this.Controls.Add(this.btnNoviKorak);
            this.Controls.Add(this.btnIzmeniSastojak);
            this.Controls.Add(this.lblNoviSastojak);
            this.Controls.Add(this.cbNoviSastojak);
            this.Controls.Add(this.lblNovaKategorija);
            this.Controls.Add(this.cbNovaKategorija);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbTezina);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.lblSviSastojci);
            this.Controls.Add(this.lbSviSastojci);
            this.Controls.Add(this.tbOpisKoraka);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblKoraci);
            this.Controls.Add(this.lbKoraci);
            this.Controls.Add(this.lblSastojci);
            this.Controls.Add(this.lbKategorije);
            this.Controls.Add(this.lblKategorije);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblCenaHC);
            this.Controls.Add(this.lblTezinaHC);
            this.Controls.Add(this.lblNazivHC);
            this.Name = "ReceptiNoviForm";
            this.Text = "ReceptiNoviForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSviSastojci;
        private System.Windows.Forms.ListBox lbSviSastojci;
        private System.Windows.Forms.TextBox tbOpisKoraka;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblKoraci;
        private System.Windows.Forms.ListBox lbKoraci;
        private System.Windows.Forms.Label lblSastojci;
        private System.Windows.Forms.ListBox lbKategorije;
        private System.Windows.Forms.Label lblKategorije;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblCenaHC;
        private System.Windows.Forms.Label lblTezinaHC;
        private System.Windows.Forms.Label lblNazivHC;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label lblNovaKategorija;
        private System.Windows.Forms.ComboBox cbNovaKategorija;
        private System.Windows.Forms.Button btnIzmeniSastojak;
        private System.Windows.Forms.Label lblNoviSastojak;
        private System.Windows.Forms.ComboBox cbNoviSastojak;
        private System.Windows.Forms.Button btnNoviKorak;
        private System.Windows.Forms.Button btnOpis;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TextBox tbKolicinaSastojka;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoviSastojakKolicina;
        private System.Windows.Forms.Button btnNoviSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTriggerName;
    }
}