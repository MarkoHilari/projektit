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
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }

        private void suljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            pizzat pizza = new pizzat();
            pizza.ShowDialog();
            this.Close();
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            this.Close();
        }

        private void ostosBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ostoskori kori = new ostoskori();
            kori.ShowDialog();
            this.Close();
        }

        
        

        private void tilaaBT_Click_1(object sender, EventArgs e)
        {
            
            ostoskori ostoskori = Application.OpenForms.OfType<ostoskori>().FirstOrDefault();

            if (ostoskori != null)
            {
                ostoskori.ClearDataGrid();
            }
        }
    }
}
