namespace Presentation_layer
{
    partial class NoviProizvodForm
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
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbTezina = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblCenaHC = new System.Windows.Forms.Label();
            this.lblTezinaHC = new System.Windows.Forms.Label();
            this.lblNazivHC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(168, 406);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(123, 23);
            this.btnSaveAll.TabIndex = 77;
            this.btnSaveAll.Text = "Dodaj proizvod";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(169, 287);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(122, 20);
            this.tbCena.TabIndex = 76;
            // 
            // tbTezina
            // 
            this.tbTezina.Location = new System.Drawing.Point(169, 87);
            this.tbTezina.Name = "tbTezina";
            this.tbTezina.Size = new System.Drawing.Size(122, 20);
            this.tbTezina.TabIndex = 75;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(169, 38);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(122, 20);
            this.tbNaziv.TabIndex = 74;
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(168, 136);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(123, 71);
            this.tbNapomena.TabIndex = 73;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(166, 120);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 72;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblCenaHC
            // 
            this.lblCenaHC.AutoSize = true;
            this.lblCenaHC.Location = new System.Drawing.Point(166, 271);
            this.lblCenaHC.Name = "lblCenaHC";
            this.lblCenaHC.Size = new System.Drawing.Size(35, 13);
            this.lblCenaHC.TabIndex = 71;
            this.lblCenaHC.Text = "Cena:";
            // 
            // lblTezinaHC
            // 
            this.lblTezinaHC.AutoSize = true;
            this.lblTezinaHC.Location = new System.Drawing.Point(167, 71);
            this.lblTezinaHC.Name = "lblTezinaHC";
            this.lblTezinaHC.Size = new System.Drawing.Size(42, 13);
            this.lblTezinaHC.TabIndex = 70;
            this.lblTezinaHC.Text = "Tezina:";
            // 
            // lblNazivHC
            // 
            this.lblNazivHC.AutoSize = true;
            this.lblNazivHC.Location = new System.Drawing.Point(166, 22);
            this.lblNazivHC.Name = "lblNazivHC";
            this.lblNazivHC.Size = new System.Drawing.Size(64, 13);
            this.lblNazivHC.TabIndex = 69;
            this.lblNazivHC.Text = "Naziv torte: ";
            // 
            // NoviProizvodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbTezina);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblCenaHC);
            this.Controls.Add(this.lblTezinaHC);
            this.Controls.Add(this.lblNazivHC);
            this.Name = "NoviProizvodForm";
            this.Text = "NoviProizvodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbTezina;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblCenaHC;
        private System.Windows.Forms.Label lblTezinaHC;
        private System.Windows.Forms.Label lblNazivHC;
    }
}