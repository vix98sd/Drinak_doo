namespace Presentation_layer
{
    partial class LogInForm
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
            this.imeRadnika = new System.Windows.Forms.Label();
            this.jmbgRadnika = new System.Windows.Forms.Label();
            this.cbRadnici = new System.Windows.Forms.ComboBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imeRadnika
            // 
            this.imeRadnika.AutoSize = true;
            this.imeRadnika.Location = new System.Drawing.Point(67, 111);
            this.imeRadnika.Name = "imeRadnika";
            this.imeRadnika.Size = new System.Drawing.Size(65, 13);
            this.imeRadnika.TabIndex = 0;
            this.imeRadnika.Text = "Ime radnika:";
            // 
            // jmbgRadnika
            // 
            this.jmbgRadnika.AutoSize = true;
            this.jmbgRadnika.Location = new System.Drawing.Point(67, 162);
            this.jmbgRadnika.Name = "jmbgRadnika";
            this.jmbgRadnika.Size = new System.Drawing.Size(93, 13);
            this.jmbgRadnika.TabIndex = 1;
            this.jmbgRadnika.Text = "JMBG (password):";
            // 
            // cbRadnici
            // 
            this.cbRadnici.FormattingEnabled = true;
            this.cbRadnici.Location = new System.Drawing.Point(215, 108);
            this.cbRadnici.Name = "cbRadnici";
            this.cbRadnici.Size = new System.Drawing.Size(159, 21);
            this.cbRadnici.TabIndex = 2;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(215, 159);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(159, 20);
            this.tbJMBG.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(175, 217);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 317);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.cbRadnici);
            this.Controls.Add(this.jmbgRadnika);
            this.Controls.Add(this.imeRadnika);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeRadnika;
        private System.Windows.Forms.Label jmbgRadnika;
        private System.Windows.Forms.ComboBox cbRadnici;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.Button btnLogIn;
    }
}