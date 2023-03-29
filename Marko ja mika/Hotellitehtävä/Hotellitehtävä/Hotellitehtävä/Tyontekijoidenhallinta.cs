using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotellitehtävä
{
    public partial class hallitseTTFM : Form
    {
        public hallitseTTFM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tyontekijoidenhallinta_Load(object sender, EventArgs e)
        {
            //TyontekijatDG.DataSource = ASIAKAS.haeAsiakkaat();
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {

        }

        private void TyontekijatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = TyontekijatDG.CurrentRow.Cells[0].Value.ToString();
            snimiTB.Text = TyontekijatDG.CurrentRow.Cells[1].Value.ToString();
            osoiteTB.Text = TyontekijatDG.CurrentRow.Cells[2].Value.ToString();
            pnroTB.Text = TyontekijatDG.CurrentRow.Cells[3].Value.ToString();
            ptpTB.Text = TyontekijatDG.CurrentRow.Cells[4].Value.ToString();
            knimiTB.Text = TyontekijatDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = knimiTB.Text;
            /*if(ASIAKAS.poistaAsiakas(ktunnus))
            {
                //TyontekijatDG.DataSource = ASIAKAS.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asíakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void hallitseTTFM_Load(object sender, EventArgs e)
        {

        }*/
        }
    }
}
