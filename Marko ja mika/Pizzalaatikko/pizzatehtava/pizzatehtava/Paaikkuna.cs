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

        // Alla olevat komennot ovat nappien komentoja navigoimiseen eri sivuilla (pizzat, juomat, ostoskori ja sulkeminen).

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            pizzat pizza = new pizzat();
            this.Hide();
            pizza.ShowDialog();
        }
                                               

        private void ostosBT_Click(object sender, EventArgs e)
        {
            ostoskori kori = new ostoskori();
            this.Hide();
            kori.Show();
        }

        private void juomatBT_Click_3(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            this.Hide();
            juoma.Show();
        }

        private void suljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();   // tama sulkee sovelluksen
        }
    }   
}
