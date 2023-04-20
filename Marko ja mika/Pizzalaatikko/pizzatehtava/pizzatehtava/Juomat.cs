﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace pizzatehtava
{
    public partial class Juomat : Form
    {
        public Juomat()
        {
            InitializeComponent();
        }

        TILAUS tilaus = new TILAUS();

        private void pizzaBT_Click(object sender, EventArgs e)  // Button pizza sivulle siirtymiseen
        {
            this.Hide();
            pizzat pizza = new pizzat();
            pizza.ShowDialog();
            this.Close();
        }

        private void ostosBT_Click(object sender, EventArgs e) // Button ostoskoriin siirtymiseen
        {
            this.Hide();
            ostoskori ostos = new ostoskori();
            ostos.ShowDialog();
            this.Close();
        }
        private void pictureBox5_Click(object sender, EventArgs e)  // Button pääikkunalle siirtymiseen 
        {
            this.Hide();
            Paaikkuna paa = new Paaikkuna();
            paa.ShowDialog();
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

                // Kaikki alla olevat komennot ovat checkbox komentoja juomien lisäämiseen ostoslistaan

        private void pieniColaCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = pieniColaCB.Text;
            if (pieniColaCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void isoColaCB_CheckedChanged(object sender, EventArgs e)
        {
            string tuote = isoColaCB.Text;
            if (isoColaCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(tuote))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void colaZeroPCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = colaZeroPCB.Text;
            if (colaZeroPCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void isoZeroCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = isoZeroCB.Text;
            if (isoZeroCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void pieniPLCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = pieniPLCB.Text;
            if (pieniPLCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void isoPLCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = isoPLCB.Text;
            if (isoPLCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void mehYlpCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = mehYlpCB.Text;
            if (mehYlpCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }

        private void mehYlisoCB_CheckedChanged(object sender, EventArgs e)
        {
            string juoma = mehYlisoCB.Text;
            if (mehYlisoCB.Checked == true)
            {
                if (tilaus.lisaaTilaus(juoma))
                {
                    //MessageBox.Show("Lisätty");
                }
            }
        }
    }
  }
