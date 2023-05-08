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
    public partial class kayttajat : Form
    {
        USERS kayttaja = new USERS();
        public kayttajat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paaikkuna ikkuna = new Paaikkuna();
            ikkuna.ShowDialog();
            this.Close();
        }

        private void lisaaAsBT_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;
            string user = eNimiTB.Text;
            string pass = salaTB.Text;
            if(user.Trim().Equals("") || pass.Trim().Equals(""))
            {
                MessageBox.Show("Vaaditut kentät - id, etunimi, salasana", "lisää käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaKayttaja = kayttaja.lisaaKayttaja(id, user, pass);
                if(lisaaKayttaja)
                {
                    dataGridView1.DataSource = kayttaja.haeKayttajat();
                    this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
                    MessageBox.Show("Uusi käyttajä lisätty onnistuneesti", "Lisää käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uusi käyttajä ei lisätty onnistuneesti", "Lisää käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kayttajat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kayttaja.haeKayttajat();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        private void muokkaaKaBT_Click(object sender, EventArgs e)
        {

        }
    }
}
