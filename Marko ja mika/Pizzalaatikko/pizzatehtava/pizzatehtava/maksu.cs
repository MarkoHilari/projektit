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
    public partial class maksu : Form
    {
        public maksu()
        {
            InitializeComponent();
        }
        // Maksu vaihtoehdot
        private void maksuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maksuCB.Text == "Pankkikortti")
            {
                korttiPANEL.Show();
                luontoPANEL.Hide();
            }
            else if(maksuCB.Text == "Luonnossa")
            {
                luontoPANEL.Show();
                korttiPANEL.Hide();
            }
            else
            {
                korttiPANEL.Hide();
                luontoPANEL.Hide();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();    // button pääikkunalle
            paa.ShowDialog();
            this.Close();
        }

        private void suljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();         // button ohjelman sulkemiseen
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            pizzat pizza = new pizzat();    // button pizzasivulle
            pizza.ShowDialog();
            this.Close();
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juomat juoma = new Juomat();      // button juomasivulle
            juoma.ShowDialog();
            this.Close();
        }

        private void ostosBT_Click(object sender, EventArgs e)
        {
            this.Hide();    
            kiitos kiitos = new kiitos();       // Button ostoskoriin
            kiitos.ShowDialog();    
            this.Close();
        }
    }
}
