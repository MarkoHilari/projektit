using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzatehtava
{
    public partial class pizzat : Form
    {
        public pizzat()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pizzat_Load(object sender, EventArgs e)
        {

        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            Application.Exit();
        }

        private void amerRB_CheckedChanged(object sender, EventArgs e)
        {
            if(amerRB.Checked == true) 
            {
                MessageBox.Show("valittu", "valittu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
