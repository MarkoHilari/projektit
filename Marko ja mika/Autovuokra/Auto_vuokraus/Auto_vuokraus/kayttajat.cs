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
            Application.Exit();
        }

        private void lisaaAsBT_Click(object sender, EventArgs e)
        {
            string id = idTB.Text;
            string eNimi = eNimiTB.Text;
            string snimi = sNimiTB.Text;
            string email = emailTB.Text;
            string puh = puhelinTB.Text;
            string user = eNimiTB.Text;
            string pass = salaTB.Text;
            if(eNimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || puh.Trim().Equals(""))
            {
                MessageBox.Show("Vaaditut kentät -  Etunimi, Sukunimi, email, Puhelin", "lisää käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaKayttaja = kayttaja.lisaaKayttaja(id, eNimi, snimi, email, puh, user, pass);
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
            string id = idTB.Text;
            string eNimi = eNimiTB.Text;
            string sNimi = sNimiTB.Text;
            string email = emailTB.Text;
            string puh = puhelinTB.Text;
            string user = eNimiTB.Text;
            string pass = salaTB.Text;

            try
            {
                
                if (eNimi.Trim().Equals("") || sNimi.Trim().Equals("") || email.Trim().Equals("") || puh.Trim().Equals(""))
                {
                    MessageBox.Show("Vaaditut kentät - Etunimi & Sukunimi + Osoite", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Boolean muokkaaAsiakas = kayttaja.muokkaaKayttaja(id, eNimi, sNimi, email, puh, user, pass);

                    if (muokkaaAsiakas)
                    {
                        dataGridView1.DataSource = kayttaja.haeKayttajat();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            eNimiTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sNimiTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            puhelinTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            /*pNroTB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            emailTB.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            puhelinTB.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();*/
        }

        private void poistaAsBT_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idTB.Text;

                if (kayttaja.poistaKayttaja(id))
                {
                    dataGridView1.DataSource = kayttaja.haeKayttajat();
                    MessageBox.Show("Käyttäjä poistettu onnistuneesti", "Poista käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Käyttäjää ei poistettu", "Poista käyttäjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tyhjennaAsBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            eNimiTB.Text = "";
            sNimiTB.Text = "";
            emailTB.Text = "";
            puhelinTB.Text = "";
            eNimiTB.Text = "";
            salaTB.Text = "";
        }

        private void carsBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot auto = new autot();
            auto.ShowDialog();
            this.Close();
        }

        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            asiakkaat asiakas = new asiakkaat();
            asiakas.ShowDialog();
            this.Close();
        }

        private void vuokrallaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vuokralla vuokra = new Vuokralla();
            vuokra.ShowDialog();
            this.Close();
        }
    }
}
