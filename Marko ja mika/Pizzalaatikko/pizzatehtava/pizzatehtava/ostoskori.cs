using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzatehtava
{
    
    public partial class ostoskori : Form
    {
        public ostoskori()
        {
            InitializeComponent();
        }
        TILAUS tilaus = new TILAUS();   

        private void ostosDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ostosDG.DataSource = tilaus.haeTilaukset();
        }

        private void ostoskori_Load(object sender, EventArgs e)
        {
            ostosDG.DataSource = tilaus.haeTilaukset();
            ostosDG.AutoResizeColumns();
        }

        private void suljeoBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            this.Close();
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            pizzat pizza = new pizzat();
            pizza.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }

        private void poistariBT_Click(object sender, EventArgs e)
        {
            string pizza = (ostosDG.CurrentRow.Cells[0].Value.ToString());
            if (tilaus.poistaTilaus(pizza))
            {
                ostosDG.DataSource = tilaus.haeTilaukset();
                MessageBox.Show("Tuote poistettu", "Tuotteen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tilaaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            maksu maksu= new maksu();
            maksu.ShowDialog();
            this.Close();
        }

        

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }
    }
}
