namespace Presentation_layer
{
    partial class ReceptiOtvoriNoviForm
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
            this.lblKolicina = new System.Windows.Forms.Label();
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
            this.lblCena = new System.Windows.Forms.Label();
            this.lblCenaHC = new System.Windows.Forms.Label();
            this.lblTezina = new System.Windows.Forms.Label();
            this.lblTezinaHC = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblNazivHC = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblKol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSviSastojci
            // 
            this.lblSviSastojci.AutoSize = true;
            this.lblSviSastojci.Location = new System.Drawing.Point(567, 21);
            this.lblSviSastojci.Name = "lblSviSastojci";
            this.lblSviSastojci.Size = new System.Drawing.Size(63, 13);
            this.lblSviSastojci.TabIndex = 37;
            this.lblSviSastojci.Text = "Svi sastojci:";
            // 
            // lbSviSastojci
            // 
            this.lbSviSastojci.FormattingEnabled = true;
            this.lbSviSastojci.Location = new System.Drawing.Point(570, 37);
            this.lbSviSastojci.Name = "lbSviSastojci";
            this.lbSviSastojci.Size = new System.Drawing.Size(207, 355);
            this.lbSviSastojci.TabIndex = 36;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(333, 172);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(19, 26);
            this.lblKolicina.TabIndex = 35;
            this.lblKolicina.Text = "-";
            // 
            // tbOpisKoraka
            // 
            this.tbOpisKoraka.Location = new System.Drawing.Point(372, 295);
            this.tbOpisKoraka.Multiline = true;
            this.tbOpisKoraka.Name = "tbOpisKoraka";
            this.tbOpisKoraka.ReadOnly = true;
            this.tbOpisKoraka.Size = new System.Drawing.Size(174, 134);
            this.tbOpisKoraka.TabIndex = 34;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(369, 279);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(67, 13);
            this.lblOpis.TabIndex = 33;
            this.lblOpis.Text = "Opis koraka:";
            // 
            // lblKoraci
            // 
            this.lblKoraci.AutoSize = true;
            this.lblKoraci.Location = new System.Drawing.Point(211, 279);
            this.lblKoraci.Name = "lblKoraci";
            this.lblKoraci.Size = new System.Drawing.Size(40, 13);
            this.lblKoraci.TabIndex = 32;
            this.lblKoraci.Text = "Koraci:";
            // 
            // lbKoraci
            // 
            this.lbKoraci.FormattingEnabled = true;
            this.lbKoraci.Location = new System.Drawing.Point(214, 295);
            this.lbKoraci.Name = "lbKoraci";
            this.lbKoraci.Size = new System.Drawing.Size(121, 134);
            this.lbKoraci.TabIndex = 31;
            this.lbKoraci.SelectedIndexChanged += new System.EventHandler(this.lbKoraci_SelectedIndexChanged);
            // 
            // lblSastojci
            // 
            this.lblSastojci.AutoSize = true;
            this.lblSastojci.Location = new System.Drawing.Point(422, 67);
            this.lblSastojci.Name = "lblSastojci";
            this.lblSastojci.Size = new System.Drawing.Size(127, 13);
            this.lblSastojci.TabIndex = 30;
            this.lblSastojci.Text = "Sastojci iz ove kategorije:";
            // 
            // lbKategorije
            // 
            this.lbKategorije.FormattingEnabled = true;
            this.lbKategorije.Location = new System.Drawing.Point(425, 83);
            this.lbKategorije.Name = "lbKategorije";
            this.lbKategorije.Size = new System.Drawing.Size(121, 186);
            this.lbKategorije.TabIndex = 29;
            this.lbKategorije.SelectedIndexChanged += new System.EventHandler(this.lbKategorije_SelectedIndexChanged);
            // 
            // lblKategorije
            // 
            this.lblKategorije.AutoSize = true;
            this.lblKategorije.Location = new System.Drawing.Point(422, 19);
            this.lblKategorije.Name = "lblKategorije";
            this.lblKategorije.Size = new System.Drawing.Size(105, 13);
            this.lblKategorije.TabIndex = 28;
            this.lblKategorije.Text = "Kategorije sastojaka:";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(425, 37);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbKategorije.TabIndex = 27;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(29, 135);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.ReadOnly = true;
            this.tbNapomena.Size = new System.Drawing.Size(123, 71);
            this.tbNapomena.TabIndex = 26;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(27, 119);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 25;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(24, 402);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(128, 26);
            this.lblCena.TabIndex = 24;
            this.lblCena.Text = "Naziv torte: ";
            // 
            // lblCenaHC
            // 
            this.lblCenaHC.AutoSize = true;
            this.lblCenaHC.Location = new System.Drawing.Point(27, 389);
            this.lblCenaHC.Name = "lblCenaHC";
            this.lblCenaHC.Size = new System.Drawing.Size(35, 13);
            this.lblCenaHC.TabIndex = 23;
            this.lblCenaHC.Text = "Cena:";
            // 
            // lblTezina
            // 
            this.lblTezina.AutoSize = true;
            this.lblTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTezina.Location = new System.Drawing.Point(25, 83);
            this.lblTezina.Name = "lblTezina";
            this.lblTezina.Size = new System.Drawing.Size(128, 26);
            this.lblTezina.TabIndex = 22;
            this.lblTezina.Text = "Naziv torte: ";
            // 
            // lblTezinaHC
            // 
            this.lblTezinaHC.AutoSize = true;
            this.lblTezinaHC.Location = new System.Drawing.Point(28, 70);
            this.lblTezinaHC.Name = "lblTezinaHC";
            this.lblTezinaHC.Size = new System.Drawing.Size(42, 13);
            this.lblTezinaHC.TabIndex = 21;
            this.lblTezinaHC.Text = "Tezina:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(24, 32);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(128, 26);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv torte: ";
            // 
            // lblNazivHC
            // 
            this.lblNazivHC.AutoSize = true;
            this.lblNazivHC.Location = new System.Drawing.Point(27, 19);
            this.lblNazivHC.Name = "lblNazivHC";
            this.lblNazivHC.Size = new System.Drawing.Size(64, 13);
            this.lblNazivHC.TabIndex = 19;
            this.lblNazivHC.Text = "Naziv torte: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(570, 407);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(207, 23);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Izmeni recept";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKol.Location = new System.Drawing.Point(226, 134);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(181, 26);
            this.lblKol.TabIndex = 70;
            this.lblKol.Text = "Kolicina sastojka:";
            // 
            // ReceptiOtvoriNoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKol);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSviSastojci);
            this.Controls.Add(this.lbSviSastojci);
            this.Controls.Add(this.lblKolicina);
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
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblCenaHC);
            this.Controls.Add(this.lblTezina);
            this.Controls.Add(this.lblTezinaHC);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblNazivHC);
            this.Name = "ReceptiOtvoriNoviForm";
            this.Text = "ReceptiOtvoriNoviForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSviSastojci;
        private System.Windows.Forms.ListBox lbSviSastojci;
        private System.Windows.Forms.Label lblKolicina;
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
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblCenaHC;
        private System.Windows.Forms.Label lblTezina;
        private System.Windows.Forms.Label lblTezinaHC;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblNazivHC;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblKol;
    }
}