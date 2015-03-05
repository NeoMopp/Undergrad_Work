using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PredatorPreyRovio
{
    public partial class Startup : Form 
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void predBut_Click(object sender, EventArgs e)
        {
            if (ipBox.Text.Length > 0)
            {
                PredatorForm pred = new PredatorForm("http://"+ipBox.Text+"/");
                pred.Show();
            }
            else
                MessageBox.Show("No IP Address Entered");
        }
    }
}
