﻿using System;
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
    public partial class pizzat : Form
    {
        public pizzat()
        {
            InitializeComponent();
        }
        TILAUS tilaus = new TILAUS();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void pizzat_Load(object sender, EventArgs e)
        {

        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Juomat juoma = new Juomat();
            juoma.ShowDialog();
            this.Close();
        }

        private void americanoCB_CheckedChanged(object sender, EventArgs e)
        {
            string pizza = americanoCB.Text;

            if (tilaus.lisaaTilaus(pizza))
            {
                //MessageBox.Show("Toimii", "");
            }
        }
    }
}
