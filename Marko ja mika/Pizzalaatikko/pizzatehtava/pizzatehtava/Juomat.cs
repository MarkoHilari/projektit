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
    public partial class Juomat : Form
    {
        public Juomat()
        {
            InitializeComponent();
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            pizzat pizza = new pizzat();
            this.Hide();
            pizza.ShowDialog();


        }
    }
}
