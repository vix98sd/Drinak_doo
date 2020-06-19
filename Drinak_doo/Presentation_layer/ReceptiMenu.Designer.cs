namespace Presentation_layer
{
    partial class ReceptiMenu
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
            this.lbProizvodi = new System.Windows.Forms.ListBox();
            this.lblProizvodi = new System.Windows.Forms.Label();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProizvodi
            // 
            this.lbProizvodi.FormattingEnabled = true;
            this.lbProizvodi.Location = new System.Drawing.Point(146, 53);
            this.lbProizvodi.Name = "lbProizvodi";
            this.lbProizvodi.Size = new System.Drawing.Size(181, 303);
            this.lbProizvodi.TabIndex = 0;
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Location = new System.Drawing.Point(143, 37);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(81, 13);
            this.lblProizvodi.TabIndex = 1;
            this.lblProizvodi.Text = "Lista proizvoda:";
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(146, 377);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(181, 23);
            this.btnOtvori.TabIndex = 2;
            this.btnOtvori.Text = "Otvori recept";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(146, 415);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(181, 23);
            this.btnNovi.TabIndex = 3;
            this.btnNovi.Text = "Dodaj novi recept";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(384, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(78, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi recept";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // ReceptiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.lblProizvodi);
            this.Controls.Add(this.lbProizvodi);
            this.Name = "ReceptiMenu";
            this.Text = "ReceptiMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProizvodi;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnObrisi;
    }
}