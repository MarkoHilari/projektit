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

        private void muokkaaAsBT_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTB.Text);
            string enimi = eNimiTB.Text;
            string snimi = sNimiTB.Text;
            string osoite = osoiteTB.Text;
            string city = cityTB.Text;
            string pnro = pNroTB.Text;
            string email = emailTB.Text;
            string puh = puhelinTB.Text;

            try
            {
                id = Convert.ToInt32(idTB.Text);
                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || city.Trim().Equals("") || pnro.Trim().Equals("")
                     || email.Trim().Equals("") || puh.Trim().Equals(""))
                {
                    MessageBox.Show("Vaaditut kentät - Etunimi & Sukunimi + Osoite", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Boolean muokkaaAsiakas = users.muokkaaAsiakasta(id, enimi, snimi, osoite, city, pnro, email, puh);

                    if (muokkaaAsiakas)
                    {
                        asiakasDG.DataSource = users.haeAsiakkaat();

                        MessageBox.Show("Asiakas tiedot päivitetty onnistuneesti", "Muokkaa asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Asiakasta ei päivitetty", "Muokkaa asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void asiakasDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = asiakasDG.CurrentRow.Cells[0].Value.ToString();
            eNimiTB.Text = asiakasDG.CurrentRow.Cells[1].Value.ToString();
            sNimiTB.Text = asiakasDG.CurrentRow.Cells[2].Value.ToString();
            osoiteTB.Text = asiakasDG.CurrentRow.Cells[3].Value.ToString();
            cityTB.Text = asiakasDG.CurrentRow.Cells[4].Value.ToString();
            pNroTB.Text = asiakasDG.CurrentRow.Cells[5].Value.ToString();
            emailTB.Text = asiakasDG.CurrentRow.Cells[6].Value.ToString();
            puhelinTB.Text = asiakasDG.CurrentRow.Cells[7].Value.ToString();
        }

        private void asiakasDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void poistaAsBT_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTB.Text);

                if (users.poistaAsiakas(id))
                {
                    asiakasDG.DataSource = users.haeAsiakkaat();
                    MessageBox.Show("Asiakas poistettu onnistuneesti", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Asiakasta ei poistettu", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayttajaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayttajat kayttajat = new kayttajat();
            kayttajat.ShowDialog();
            this.Close();
        }

        private void vuokrallaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vuokralla vuokralla = new Vuokralla();
            vuokralla.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
