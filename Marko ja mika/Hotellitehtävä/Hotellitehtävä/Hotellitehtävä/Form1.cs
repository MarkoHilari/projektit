using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotellitehtävä
{
    public partial class kirjausFM : Form
    {
        public kirjausFM()
        {
            InitializeComponent();
        }

        private void kirjauduBT_Click(object sender, EventArgs e)
        {
            YHDISTA yhdista = new YHDISTA();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            String kysely = "SELECT * FROM `kayttajat` WHERE `kayttajanimi`=@usn AND `salasana`=@pass";

            cmd.CommandText = kysely;
            cmd.Connection = yhdista.otaYhteys();

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Kyllä");
            }
            else
            {
                MessageBox.Show("Ei");
            }
        }
    }
}
