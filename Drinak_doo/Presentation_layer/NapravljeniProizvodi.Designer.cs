namespace Presentation_layer
{
    partial class NapravljeniProizvodi
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.cbDatum = new System.Windows.Forms.ComboBox();
            this.lbNapravljeni = new System.Windows.Forms.ListBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(9, 10);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum:";
            // 
            // cbDatum
            // 
            this.cbDatum.FormattingEnabled = true;
            this.cbDatum.Items.AddRange(new object[] {
            "Svi"});
            this.cbDatum.Location = new System.Drawing.Point(12, 26);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(145, 21);
            this.cbDatum.TabIndex = 1;
            this.cbDatum.SelectedIndexChanged += new System.EventHandler(this.cbDatum_SelectedIndexChanged);
            // 
            // lbNapravljeni
            // 
            this.lbNapravljeni.FormattingEnabled = true;
            this.lbNapravljeni.Location = new System.Drawing.Point(12, 53);
            this.lbNapravljeni.Name = "lbNapravljeni";
            this.lbNapravljeni.Size = new System.Drawing.Size(319, 238);
            this.lbNapravljeni.TabIndex = 2;
            this.lbNapravljeni.SelectedIndexChanged += new System.EventHandler(this.lbNapravljeni_SelectedIndexChanged);
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 303);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 3;
            this.lblNapomena.Text = "Napomena:";
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(15, 320);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.ReadOnly = true;
            this.tbNapomena.Size = new System.Drawing.Size(384, 106);
            this.tbNapomena.TabIndex = 4;
            // 
            // NapravljeniProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lbNapravljeni);
            this.Controls.Add(this.cbDatum);
            this.Controls.Add(this.lblDatum);
            this.Name = "NapravljeniProizvodi";
            this.Text = "NapravljeniProizvodi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cbDatum;
        private System.Windows.Forms.ListBox lbNapravljeni;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox tbNapomena;
    }
}