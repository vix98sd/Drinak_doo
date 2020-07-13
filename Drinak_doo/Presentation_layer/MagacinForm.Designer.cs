namespace Presentation_layer
{
    partial class MagacinForm
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
            this.lbRoba = new System.Windows.Forms.ListBox();
            this.lblRoba = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.lblJM = new System.Windows.Forms.Label();
            this.cbJM = new System.Windows.Forms.ComboBox();
            this.lblNovaKolicina = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.rbDodaj = new System.Windows.Forms.RadioButton();
            this.rbSkini = new System.Windows.Forms.RadioButton();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRoba
            // 
            this.lbRoba.FormattingEnabled = true;
            this.lbRoba.Location = new System.Drawing.Point(12, 44);
            this.lbRoba.Name = "lbRoba";
            this.lbRoba.Size = new System.Drawing.Size(177, 394);
            this.lbRoba.TabIndex = 0;
            this.lbRoba.SelectedIndexChanged += new System.EventHandler(this.lbRoba_SelectedIndexChanged);
            // 
            // lblRoba
            // 
            this.lblRoba.AutoSize = true;
            this.lblRoba.Location = new System.Drawing.Point(12, 29);
            this.lblRoba.Name = "lblRoba";
            this.lblRoba.Size = new System.Drawing.Size(70, 13);
            this.lblRoba.TabIndex = 1;
            this.lblRoba.Text = "Pregled robe:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(240, 89);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 2;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(237, 73);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kolicina:";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(240, 137);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.ReadOnly = true;
            this.tbKolicina.Size = new System.Drawing.Size(100, 20);
            this.tbKolicina.TabIndex = 5;
            // 
            // lblJM
            // 
            this.lblJM.AutoSize = true;
            this.lblJM.Location = new System.Drawing.Point(237, 170);
            this.lblJM.Name = "lblJM";
            this.lblJM.Size = new System.Drawing.Size(75, 13);
            this.lblJM.TabIndex = 6;
            this.lblJM.Text = "Jedinica mere:";
            // 
            // cbJM
            // 
            this.cbJM.FormattingEnabled = true;
            this.cbJM.Location = new System.Drawing.Point(240, 186);
            this.cbJM.Name = "cbJM";
            this.cbJM.Size = new System.Drawing.Size(121, 21);
            this.cbJM.TabIndex = 7;
            // 
            // lblNovaKolicina
            // 
            this.lblNovaKolicina.AutoSize = true;
            this.lblNovaKolicina.Location = new System.Drawing.Point(237, 215);
            this.lblNovaKolicina.Name = "lblNovaKolicina";
            this.lblNovaKolicina.Size = new System.Drawing.Size(97, 13);
            this.lblNovaKolicina.TabIndex = 9;
            this.lblNovaKolicina.Text = "Kolicina za izmenu:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(240, 231);
            this.nudKolicina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(100, 20);
            this.nudKolicina.TabIndex = 10;
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Checked = true;
            this.rbDodaj.Location = new System.Drawing.Point(240, 257);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(99, 17);
            this.rbDodaj.TabIndex = 11;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj na stanje";
            this.rbDodaj.UseVisualStyleBackColor = true;
            // 
            // rbSkini
            // 
            this.rbSkini.AutoSize = true;
            this.rbSkini.Location = new System.Drawing.Point(240, 280);
            this.rbSkini.Name = "rbSkini";
            this.rbSkini.Size = new System.Drawing.Size(93, 17);
            this.rbSkini.TabIndex = 12;
            this.rbSkini.Text = "Skini sa stanja";
            this.rbSkini.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(286, 386);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(286, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // MagacinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rbSkini);
            this.Controls.Add(this.rbDodaj);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.lblNovaKolicina);
            this.Controls.Add(this.cbJM);
            this.Controls.Add(this.lblJM);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.lblRoba);
            this.Controls.Add(this.lbRoba);
            this.Name = "MagacinForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRoba;
        private System.Windows.Forms.Label lblRoba;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label lblJM;
        private System.Windows.Forms.ComboBox cbJM;
        private System.Windows.Forms.Label lblNovaKolicina;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.RadioButton rbSkini;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
    }
}