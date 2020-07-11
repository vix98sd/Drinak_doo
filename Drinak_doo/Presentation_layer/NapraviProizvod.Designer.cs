namespace Presentation_layer
{
    partial class NapraviProizvod
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
            this.cbProizvodi = new System.Windows.Forms.ComboBox();
            this.lblProizvodi = new System.Windows.Forms.Label();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.btnNapravi = new System.Windows.Forms.Button();
            this.btnRecept = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbProizvodi
            // 
            this.cbProizvodi.FormattingEnabled = true;
            this.cbProizvodi.Location = new System.Drawing.Point(12, 29);
            this.cbProizvodi.Name = "cbProizvodi";
            this.cbProizvodi.Size = new System.Drawing.Size(121, 21);
            this.cbProizvodi.TabIndex = 0;
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Location = new System.Drawing.Point(9, 13);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(93, 13);
            this.lblProizvodi.TabIndex = 1;
            this.lblProizvodi.Text = "Izaberite proizvod:";
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(12, 108);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(384, 106);
            this.tbNapomena.TabIndex = 6;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(9, 91);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 5;
            this.lblNapomena.Text = "Napomena:";
            // 
            // btnNapravi
            // 
            this.btnNapravi.Location = new System.Drawing.Point(276, 281);
            this.btnNapravi.Name = "btnNapravi";
            this.btnNapravi.Size = new System.Drawing.Size(120, 23);
            this.btnNapravi.TabIndex = 7;
            this.btnNapravi.Text = "Napravi proizvod";
            this.btnNapravi.UseVisualStyleBackColor = true;
            this.btnNapravi.Click += new System.EventHandler(this.btnNapravi_Click);
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(276, 29);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(120, 23);
            this.btnRecept.TabIndex = 8;
            this.btnRecept.Text = "Pogledaj recept";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(276, 58);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(120, 23);
            this.btnPDF.TabIndex = 9;
            this.btnPDF.Text = "Prikazi PDF recept";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // NapraviProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 317);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.btnNapravi);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblProizvodi);
            this.Controls.Add(this.cbProizvodi);
            this.Name = "NapraviProizvod";
            this.Text = "NapraviProizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProizvodi;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Button btnNapravi;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnPDF;
    }
}