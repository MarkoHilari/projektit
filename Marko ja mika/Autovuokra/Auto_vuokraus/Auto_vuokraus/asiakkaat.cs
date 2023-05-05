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
    public partial class asiakkaat : Form
    {
        USERS users = new USERS();
        public asiakkaat()
        {
            InitializeComponent();
        }

        private void tyhjennaAsBT_Click(object sender, EventArgs e)
        {
            eNimiTB.Text = string.Empty;
            sNimiTB.Text = string.Empty;
            osoiteTB.Text = string.Empty;
            cityTB.Text = string.Empty;
            pNroTB.Text = string.Empty;
            emailTB.Text = string.Empty;
            puhelinTB.Text = string.Empty;
        }

        private void carsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }

        private void lisaaAsiBT_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;
            string enimi = eNimiTB.Text;
            string snimi = sNimiTB.Text;
            string osoite = osoiteTB.Text;
            string city = cityTB.Text;
            string pnro = pNroTB.Text;
            string email = emailTB.Text;
            string puh = puhelinTB.Text;

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || city.Trim().Equals("") ||
                pnro.Trim().Equals("") || email.Trim().Equals("") || puh.Trim().Equals(""))
            {
                MessageBox.Show("Täytä kaikki kentät", "Tyhjä kenttä!", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                Boolean lisaaAsiakas = users.lisaaAsiakas(id, enimi, snimi, osoite, city, pnro,email, puh);

                if(lisaaAsiakas)
                {
                    asiakasDG.DataSource = users.haeAsiakkaat();
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Asiakasta ei lisätty", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void asiakkaat_Load(object sender, EventArgs e)
        {
            asiakasDG.DataSource = users.haeAsiakkaat();//
        }
    }
}
