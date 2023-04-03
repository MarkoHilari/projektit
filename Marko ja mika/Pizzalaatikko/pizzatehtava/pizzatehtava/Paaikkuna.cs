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
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            pizzat pizza = new pizzat();
            this.Hide();
            pizza.ShowDialog();
            

        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
        }

        private void suljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void juomatBT_Click_1(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            this.Hide();
            juoma.ShowDialog();
                   }

        private void juomatBT_Click_2(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            this.Hide();
            juoma.Show();
        }

        private void ostosBT_Click(object sender, EventArgs e)
        {
            ostoskori kori = new ostoskori();
            this.Hide();
            kori.Show();
            paaikkuna.Hide();
        }

       
    }
}
