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
      

        private void pizzat_Load(object sender, EventArgs e)
        {

        }

        private void juomatBT_Click(object sender, EventArgs e)   // Button juomasivulle
        {
            this.Hide();
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            this.Close();
        }
        private void ostosBT_Click(object sender, EventArgs e)
        {
            this.Hide();                                            // button ostoskorille
            ostoskori ostos = new ostoskori();
            ostos.ShowDialog();
            this.Close();
        }

      // alla checkboxeja pizzojen lisäämiseen

        private void americanoCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = americanoCB.Text;
            
            if(americanoCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                                   
                }
            }                      
        }

        private void meheCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = meheCB.Text;
            if (meheCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }
            }
        }

        private void troCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = troCB.Text;
            if (troCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void meheSpCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = meheSpCB.Text;
            if (meheSpCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void rinneCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = rinneCB.Text;
            if (rinneCB.Checked)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void speciSCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = speciSCB.Text;
            if (speciSCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void tuliCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = tuliCB.Text;
            if (tuliCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }

        private void softCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = softCB.Text;
            if (softCB.Checked)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Toimii", "");
                }

            }
        }
            // Aloitus sivulle palaamisen nappi
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();                
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }
    }
}
