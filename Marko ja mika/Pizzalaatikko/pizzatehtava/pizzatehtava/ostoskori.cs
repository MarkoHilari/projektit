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

        private void ostosDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  varausTB.Text = varausDG.CurrentRow.Cells[0].Value.ToString();
            int huoneID = Convert.ToInt32(varausDG.CurrentRow.Cells[1].Value.ToString());
            huonetyyppiCB.SelectedValue = huone.haeHuoneTyyppi(huoneID);
            huoneenNumeroCB.Text = huoneID.ToString();     */
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

      
    }
}
