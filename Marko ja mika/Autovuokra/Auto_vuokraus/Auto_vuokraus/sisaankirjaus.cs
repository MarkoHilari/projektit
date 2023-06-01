using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Auto_vuokraus
{
    public partial class sisaankirjaus : Form
    {
        public sisaankirjaus()
        {
            InitializeComponent();
        }

        private void kirjausBT_Click(object sender, EventArgs e)// Sisäänkirjautuminen
        {
            YHDISTA yhdista = new YHDISTA();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            String kysely = "SELECT * FROM `kayttaja` WHERE user=@usn AND pass=@pass";//Käydään läpi löytyykö tunnuksia

            cmd.CommandText = kysely;
            cmd.Connection = yhdista.otaYhteys();

            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = kayttajaTB.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salaSanaTB.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)//Jos käyttäjä löytyy avataan pääikkuna
            {
                this.Hide();
                Paaikkuna form2 = new Paaikkuna();
                form2.Show();
                //
            }
            else
            {
                if (kayttajaTB.Text.Trim().Equals(""))//Käydään läpi onko käyttäjänimi kenttään asetettu tietoa
                {
                    MessageBox.Show("Syötä käyttäjänimesi", "Tyhjä käyttäjänimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salaSanaTB.Text.Trim().Equals(""))//Käydään läpi onko salasan kenttään asetettu tietoa
                {
                    MessageBox.Show("Syötä salasana", "Tyhjä salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//Kerrotaan jos käyttäjänimi tai salasana on virheellinen
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy! ", "Tarkista käyttäjänimi tai salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)//Tyhjennä käyttäjä ja salasana kentät
        {
            kayttajaTB.Text = "";
            salaSanaTB.Text = "";
        }
    }
}
