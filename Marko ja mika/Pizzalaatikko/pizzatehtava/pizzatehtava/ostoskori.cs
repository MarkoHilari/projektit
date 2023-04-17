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

        private void ostoskori_Load(object sender, EventArgs e) // ostoskorin lataaminen ja sovittaminen datagridiin
        {
            ostosDG.DataSource = tilaus.haeTilaukset();
            ostosDG.AutoResizeColumns();
            yhteensaLB.Visible = true;
            //yhteensaLB.Text = tilaus.haeSumma();
                        
        }
  
        private void poistariBT_Click(object sender, EventArgs e)   // Poistamisnapin komennot yksittäisen tuotteen poistoon 
        {
            string pizza = (ostosDG.CurrentRow.Cells[0].Value.ToString());
            if (tilaus.poistaTilaus(pizza))
            {
                ostosDG.DataSource = tilaus.haeTilaukset();
                MessageBox.Show("Tuote poistettu", "Tuotteen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void suljeoBT_Click(object sender, EventArgs e)
        {
            Application.Exit(); //tämä sulkee sovelluksen
        }

            // kaikki alla olevat napit ovat navigointeja eri sivuille

        private void juomatBT_Click(object sender, EventArgs e)      // Juomat
        {
            this.Hide();
            Juomat juoma = new Juomat();         
            juoma.ShowDialog();
            this.Close();
        }

        private void pizzaBT_Click(object sender, EventArgs e)      // Pizzat
        {
            this.Hide();
            pizzat pizza = new pizzat();
            pizza.ShowDialog();
            this.Close();
        }
       
        private void tilaaBT_Click(object sender, EventArgs e)       // Tilaus
        {
            this.Hide();
            maksu maksu = new maksu();
            maksu.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)     // Pääikkuna
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }

        private void yhteensaLB_Click(object sender, EventArgs e)
        {
            //yhteensaLB.
        }
    }
}
