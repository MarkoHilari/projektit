using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_vuokraus
{
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        
        

        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }

        private void carsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }
    }
}
