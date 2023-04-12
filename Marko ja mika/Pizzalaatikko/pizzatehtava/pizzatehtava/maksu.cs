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
    public partial class maksu : Form
    {
        public maksu()
        {
            InitializeComponent();
        }

        private void maksuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(maksuCB.Text == "Pankkikortti")
            {
                korttiPANEL.Show();
            }
            else { korttiPANEL.Hide();}
        }
    }
}
