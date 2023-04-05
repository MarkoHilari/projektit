using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
