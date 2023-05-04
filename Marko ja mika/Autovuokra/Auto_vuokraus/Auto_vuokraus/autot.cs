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

        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            asiakkaat asiakkaat = new asiakkaat();
            asiakkaat.ShowDialog();
            this.Close();
        }

        private void vuokrallaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vuokralla vuokralla = new Vuokralla();
            vuokralla.ShowDialog();
            this.Close();
        }

        private void palautuneetBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            palautuneet palautuneet = new palautuneet();
            palautuneet.ShowDialog();
            this.Close();
        }

        private void kayttajatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayttajat kayttajat = new kayttajat();
            kayttajat.ShowDialog();
            this.Close();
        }

        private void ratsuniRB_CheckedChanged(object sender, EventArgs e)
        {
            string vapaa = vuokrallaDG.CurrentRow.Cells[3].Value.ToString();

            if (vapaa.Equals("KYLLÄ"))
            {
                radioButtonYes.Checked = true;
            }
        }
    }
}
