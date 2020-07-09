namespace Presentation_layer
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSviRadnici = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.btnNapravi = new System.Windows.Forms.Button();
            this.btnRecepti = new System.Windows.Forms.Button();
            this.btnNoviProizvod = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.timerDT = new System.Windows.Forms.Timer(this.components);
            this.btnMagacin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSviRadnici
            // 
            this.btnSviRadnici.Location = new System.Drawing.Point(145, 141);
            this.btnSviRadnici.Name = "btnSviRadnici";
            this.btnSviRadnici.Size = new System.Drawing.Size(155, 23);
            this.btnSviRadnici.TabIndex = 0;
            this.btnSviRadnici.Text = "Svi radnici";
            this.btnSviRadnici.UseVisualStyleBackColor = true;
            this.btnSviRadnici.Click += new System.EventHandler(this.btnSviRadnici_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.Location = new System.Drawing.Point(145, 183);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(155, 23);
            this.btnProizvodi.TabIndex = 1;
            this.btnProizvodi.Text = "Napravljeni proizvodi";
            this.btnProizvodi.UseVisualStyleBackColor = true;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // btnNapravi
            // 
            this.btnNapravi.Location = new System.Drawing.Point(145, 223);
            this.btnNapravi.Name = "btnNapravi";
            this.btnNapravi.Size = new System.Drawing.Size(155, 23);
            this.btnNapravi.TabIndex = 2;
            this.btnNapravi.Text = "Napravi proizvod";
            this.btnNapravi.UseVisualStyleBackColor = true;
            this.btnNapravi.Click += new System.EventHandler(this.btnNapravi_Click);
            // 
            // btnRecepti
            // 
            this.btnRecepti.Location = new System.Drawing.Point(145, 265);
            this.btnRecepti.Name = "btnRecepti";
            this.btnRecepti.Size = new System.Drawing.Size(155, 23);
            this.btnRecepti.TabIndex = 3;
            this.btnRecepti.Text = "Recepti";
            this.btnRecepti.UseVisualStyleBackColor = true;
            this.btnRecepti.Click += new System.EventHandler(this.btnRecepti_Click);
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.Location = new System.Drawing.Point(145, 304);
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Size = new System.Drawing.Size(155, 23);
            this.btnNoviProizvod.TabIndex = 4;
            this.btnNoviProizvod.Text = "Unesi novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = true;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(12, 392);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(146, 26);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Ime Radnika";
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.Location = new System.Drawing.Point(48, 418);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(70, 20);
            this.lblPozicija.TabIndex = 6;
            this.lblPozicija.Text = "Pozicija";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(151, 39);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(138, 31);
            this.lblCompany.TabIndex = 7;
            this.lblCompany.Text = "Sopranos";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(166, 70);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(109, 17);
            this.lblOwner.TabIndex = 8;
            this.lblOwner.Text = "- Drinak doo -";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(349, 392);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(90, 20);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "01-Jan-20";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(347, 412);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(104, 26);
            this.lblVreme.TabIndex = 10;
            this.lblVreme.Text = "00:00:00";
            // 
            // timerDT
            // 
            this.timerDT.Interval = 1000;
            this.timerDT.Tick += new System.EventHandler(this.timerDT_Tick);
            // 
            // btnMagacin
            // 
            this.btnMagacin.Location = new System.Drawing.Point(145, 341);
            this.btnMagacin.Name = "btnMagacin";
            this.btnMagacin.Size = new System.Drawing.Size(155, 23);
            this.btnMagacin.TabIndex = 11;
            this.btnMagacin.Text = "Magacin";
            this.btnMagacin.UseVisualStyleBackColor = true;
            this.btnMagacin.Click += new System.EventHandler(this.btnMagacin_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnMagacin);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.btnRecepti);
            this.Controls.Add(this.btnNapravi);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.btnSviRadnici);
            this.Name = "MainMenuForm";
            this.Text = "MainManuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSviRadnici;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.Button btnNapravi;
        private System.Windows.Forms.Button btnRecepti;
        private System.Windows.Forms.Button btnNoviProizvod;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Timer timerDT;
        private System.Windows.Forms.Button btnMagacin;
    }
}