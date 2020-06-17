using Business_layer;
using Data_layer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JediniceMereBusiness JMB = new JediniceMereBusiness();
            string s = "";
            foreach (JedinicaMere jm in JMB.GetJediniceMere())
                s += jm.Id_jm + " " + jm.Naziv + "\n";
            MessageBox.Show(s);
        }
    }
}
