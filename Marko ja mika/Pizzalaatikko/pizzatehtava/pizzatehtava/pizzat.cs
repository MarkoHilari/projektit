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
        TILAUS tilaus = new TILAUS();
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
            this.Hide();
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            this.Close();
        }
        private void ostosBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ostoskori ostos = new ostoskori();
            ostos.ShowDialog();
            this.Close();
        }

        /*private void americanoCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = americanoCB.Text;

            if (tilaus.lisaaTilaus(pizza))
            {
                //MessageBox.Show("Toimii", "");
            }
            
        }*/



        private void americanoCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = americanoCB.Text;
            if(americanoCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
          

            
        }

        private void meheCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = meheCB.Text;
            if (meheCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }
            }
        }

        private void troCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = troCB.Text;
            if (troCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void meheSpCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = meheCB.Text;
            if (meheCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void rinneCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = rinneCB.Text;
            if (rinneCB.Checked)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void speciSCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = meheSpCB.Text;
            if (meheSpCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void tuliCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = tuliCB.Text;
            if (tuliCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void softCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = softCB.Text;
            if (softCB.Checked)
            {
                if (tilaus.lisaaTilaus(pizza))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }
    }
}
