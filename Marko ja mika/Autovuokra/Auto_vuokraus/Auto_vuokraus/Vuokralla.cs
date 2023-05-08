using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Auto_vuokraus

{
    public partial class Vuokralla : Form
    {

        USERS users = new USERS();

       
        public Vuokralla()
        {
            InitializeComponent();
        }

        private void autotBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            autot autot = new autot();
            autot.ShowDialog();
            this.Close();
        }

        private void asiakkaatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            asiakkaat asiakas = new asiakkaat();
            asiakas.ShowDialog();
            this.Close();
        }

        private void palautuneetBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            palautuneet palautuneet = new palautuneet();   
            palautuneet.ShowDialog();
            this.Close();
        }

        private void kayttajatBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayttajat kayttajat = new kayttajat();
            kayttajat.ShowDialog();
            this.Close();
        }

        private void vuokrallaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vuokrallaDG.DataSource = users.haeKalusto();
        }

        private void Vuokralla_Load(object sender, EventArgs e)
        {
            vuokrallaDG.DataSource = users.haeKalusto();
           // vuokrallaDG.AutoResizeColumns();
            this.vuokrallaDG.DefaultCellStyle.Font = new Font("Tahoma", 15);
            vuokrallaDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        


        private void vuokrallaDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string vapaa = vuokrallaDG.CurrentRow.Cells[4].Value.ToString();

            if (vapaa.Equals("vapaa"))
            {
                 radioBT.Checked = true;
            }
            else if (vapaa.Equals("varattu"))
            {
                radioBT.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public Bitmap GrayScaleFilter(Bitmap pictureBox_1)
        {
            Bitmap grayScale = new Bitmap(pictureBox_1.Width, pictureBox_1.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = pictureBox_1.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }
    }
}
