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

    public partial class autot : Form
    {
        Vuokralla vuokra = new Vuokralla();
       

        public autot()
        {
            InitializeComponent();
        }

        private void asiakkaatBT_Click(object sender, EventArgs e)  // asiakas sivun button
        {
            this.Hide();
            asiakkaat asiakkaat = new asiakkaat();
            asiakkaat.ShowDialog();
            this.Close();
        }

        private void vuokrallaBT_Click(object sender, EventArgs e)  // vuokralla sivun button
        {
            this.Hide();
            Vuokralla vuokralla = new Vuokralla();
            vuokralla.ShowDialog();
            this.Close();
        }

     

        private void kayttajatBT_Click(object sender, EventArgs e)  // käyttajat sivun button
        {
            this.Hide();
            kayttajat kayttajat = new kayttajat();
            kayttajat.ShowDialog();
            this.Close();
        }

        private void autot_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)      // ohjelman sulkemis button
        {
            Application.Exit();
        }
    }
}
