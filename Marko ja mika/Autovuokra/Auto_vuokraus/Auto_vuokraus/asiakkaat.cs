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
    public partial class asiakkaat : Form
    {
        public asiakkaat()
        {
            InitializeComponent();
        }

        private void tyhjennaAsBT_Click(object sender, EventArgs e)
        {
            eNimiTB.Text = string.Empty;
            sNimiTB.Text = string.Empty;
            osoiteTB.Text = string.Empty;
            cityTB.Text = string.Empty;
            pNroTB.Text = string.Empty;
            emailTB.Text = string.Empty;
            puhelinTB.Text = string.Empty;
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
