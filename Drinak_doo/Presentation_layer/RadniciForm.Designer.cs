namespace Presentation_layer
{
    partial class RadniciForm
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
            this.lbRadnici = new System.Windows.Forms.ListBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.ibiTelefon = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.tbJmbg = new System.Windows.Forms.TextBox();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.cbPozicija = new System.Windows.Forms.ComboBox();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.lblFunction = new System.Windows.Forms.Label();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRadnici
            // 
            this.lbRadnici.FormattingEnabled = true;
            this.lbRadnici.Location = new System.Drawing.Point(12, 12);
            this.lbRadnici.Name = "lbRadnici";
            this.lbRadnici.Size = new System.Drawing.Size(216, 355);
            this.lbRadnici.TabIndex = 0;
            this.lbRadnici.SelectedIndexChanged += new System.EventHandler(this.lbRadnici_SelectedIndexChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(293, 54);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(296, 70);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(199, 20);
            this.tbIme.TabIndex = 2;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(296, 116);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(199, 20);
            this.tbPrezime.TabIndex = 4;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(293, 100);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(296, 162);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(199, 20);
            this.tbTelefon.TabIndex = 6;
            // 
            // ibiTelefon
            // 
            this.ibiTelefon.AutoSize = true;
            this.ibiTelefon.Location = new System.Drawing.Point(293, 146);
            this.ibiTelefon.Name = "ibiTelefon";
            this.ibiTelefon.Size = new System.Drawing.Size(46, 13);
            this.ibiTelefon.TabIndex = 5;
            this.ibiTelefon.Text = "Telefon:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(296, 207);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(199, 20);
            this.tbAdresa.TabIndex = 8;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(293, 191);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "Adresa:";
            // 
            // tbJmbg
            // 
            this.tbJmbg.Location = new System.Drawing.Point(296, 248);
            this.tbJmbg.Name = "tbJmbg";
            this.tbJmbg.Size = new System.Drawing.Size(199, 20);
            this.tbJmbg.TabIndex = 10;
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(293, 232);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(39, 13);
            this.lblJmbg.TabIndex = 9;
            this.lblJmbg.Text = "JMBG:";
            // 
            // cbPozicija
            // 
            this.cbPozicija.FormattingEnabled = true;
            this.cbPozicija.Location = new System.Drawing.Point(296, 304);
            this.cbPozicija.Name = "cbPozicija";
            this.cbPozicija.Size = new System.Drawing.Size(199, 21);
            this.cbPozicija.TabIndex = 11;
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Location = new System.Drawing.Point(293, 288);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(46, 13);
            this.lblPozicija.TabIndex = 12;
            this.lblPozicija.Text = "Pozicija:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(420, 409);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 13;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(12, 404);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(246, 13);
            this.lblFunction.TabIndex = 14;
            this.lblFunction.Text = "Izaberite radnika da dobijete informacije iz funkcije!";
            // 
            // lblProcedure
            // 
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Location = new System.Drawing.Point(12, 377);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(257, 13);
            this.lblProcedure.TabIndex = 15;
            this.lblProcedure.Text = "Izaberite radnika da dobijete informacije iz procedure!";
            // 
            // RadniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.lblProcedure);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.cbPozicija);
            this.Controls.Add(this.tbJmbg);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.ibiTelefon);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lbRadnici);
            this.Name = "RadniciForm";
            this.Text = "RadniciForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRadnici;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label ibiTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox tbJmbg;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.ComboBox cbPozicija;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label lblProcedure;
    }
}