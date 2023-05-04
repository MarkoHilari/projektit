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
    public partial class Vuokralla : Form
    {
        USERS users = new USERS();

        public Vuokralla()
        {
            InitializeComponent();
        }

        private void autotBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }

        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            asiakkaat asiakas = new asiakkaat();
            asiakas.ShowDialog();
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

        private void vuokrallaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vuokrallaDG.DataSource = users.haeKalusto();
        }

        private void Vuokralla_Load(object sender, EventArgs e)
        {
            vuokrallaDG.DataSource = users.haeKalusto();
           // vuokrallaDG.AutoResizeColumns();
            this.vuokrallaDG.DefaultCellStyle.Font = new Font("Tahoma", 15);
            vuokrallaDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

      /*  private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string vapaa = vuokrallaDG.CurrentRow.Cells[4].Value.ToString();

            if (vapaa.Equals("KYLLÄ"))
            {
                radioButtonYes.Checked = true;
            }
        }*/
    }
}
