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
    public partial class Paaikkuna : Form
    {
        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void pizzaBT_Click(object sender, EventArgs e)
        {
            pizzat pizza = new pizzat();
            pizza.Show();
        }

        private void juomatBT_Click(object sender, EventArgs e)
        {
            Juomat juoma = new Juomat();
            juoma.Show();
        }
    }
}
