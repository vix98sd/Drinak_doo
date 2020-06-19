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
            this.btnSviRadnici = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.btnNapravi = new System.Windows.Forms.Button();
            this.btnRecepti = new System.Windows.Forms.Button();
            this.btnNoviProizvod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSviRadnici
            // 
            this.btnSviRadnici.Location = new System.Drawing.Point(145, 100);
            this.btnSviRadnici.Name = "btnSviRadnici";
            this.btnSviRadnici.Size = new System.Drawing.Size(155, 23);
            this.btnSviRadnici.TabIndex = 0;
            this.btnSviRadnici.Text = "Svi radnici";
            this.btnSviRadnici.UseVisualStyleBackColor = true;
            this.btnSviRadnici.Click += new System.EventHandler(this.btnSviRadnici_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.Location = new System.Drawing.Point(145, 142);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(155, 23);
            this.btnProizvodi.TabIndex = 1;
            this.btnProizvodi.Text = "Napravljeni proizvodi";
            this.btnProizvodi.UseVisualStyleBackColor = true;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // btnNapravi
            // 
            this.btnNapravi.Location = new System.Drawing.Point(145, 182);
            this.btnNapravi.Name = "btnNapravi";
            this.btnNapravi.Size = new System.Drawing.Size(155, 23);
            this.btnNapravi.TabIndex = 2;
            this.btnNapravi.Text = "Napravi proizvod";
            this.btnNapravi.UseVisualStyleBackColor = true;
            this.btnNapravi.Click += new System.EventHandler(this.btnNapravi_Click);
            // 
            // btnRecepti
            // 
            this.btnRecepti.Location = new System.Drawing.Point(145, 224);
            this.btnRecepti.Name = "btnRecepti";
            this.btnRecepti.Size = new System.Drawing.Size(155, 23);
            this.btnRecepti.TabIndex = 3;
            this.btnRecepti.Text = "Recepti";
            this.btnRecepti.UseVisualStyleBackColor = true;
            this.btnRecepti.Click += new System.EventHandler(this.btnRecepti_Click);
            // 
            // btnNoviProizvod
            // 
            this.btnNoviProizvod.Location = new System.Drawing.Point(145, 263);
            this.btnNoviProizvod.Name = "btnNoviProizvod";
            this.btnNoviProizvod.Size = new System.Drawing.Size(155, 23);
            this.btnNoviProizvod.TabIndex = 4;
            this.btnNoviProizvod.Text = "Unesi novi proizvod";
            this.btnNoviProizvod.UseVisualStyleBackColor = true;
            this.btnNoviProizvod.Click += new System.EventHandler(this.btnNoviProizvod_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnNoviProizvod);
            this.Controls.Add(this.btnRecepti);
            this.Controls.Add(this.btnNapravi);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.btnSviRadnici);
            this.Name = "MainMenuForm";
            this.Text = "MainManuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSviRadnici;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.Button btnNapravi;
        private System.Windows.Forms.Button btnRecepti;
        private System.Windows.Forms.Button btnNoviProizvod;
    }
}