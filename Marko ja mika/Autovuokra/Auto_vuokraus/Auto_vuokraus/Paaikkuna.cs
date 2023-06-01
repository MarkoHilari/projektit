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



        // Asiakkaat button painallus avaa asiakkaat sivun
        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            asiakkaat asiakkaat = new asiakkaat();
            asiakkaat.ShowDialog();
            this.Close();
        }
        // Cars button painallus avaa autot välilehden
        private void carsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }
        //Käyttäjä button avaa käyttäjät välilehden
        private void kayttajatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayttajat kayttajat = new kayttajat();
            kayttajat.ShowDialog();
            this.Close();
        }
        // Vuokralla button avaa vuokralla välilehden
        private void vuokrallaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vuokralla vuokralla = new Vuokralla();
            vuokralla.ShowDialog();
            this.Close();
        }

        
    }
}
