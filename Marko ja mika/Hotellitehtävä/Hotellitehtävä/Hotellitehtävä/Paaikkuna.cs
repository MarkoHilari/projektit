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
    public partial class PaaikkunaFM : Form
    {
        public PaaikkunaFM()
        {
            InitializeComponent();
        }

        private void PaaikkunaFM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseHenkilökuntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hallitseTTFM hallitseTT = new hallitseTTFM();
            hallitseTT.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varausFM varaukset = new varausFM();
            varaukset.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huoneFM huoneet = new huoneFM();
            huoneet.ShowDialog();
        }
    }
}
