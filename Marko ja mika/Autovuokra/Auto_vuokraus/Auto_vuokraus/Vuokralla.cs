using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

            //string auto = vuokrallaDG.Rows[0].Cells[1].Value.ToString();
            string tilanne = vuokrallaDG.CurrentRow.Cells[4].Value.ToString();

            for (int auto = 0; auto < vuokrallaDG.Rows.Count; auto++)
            {
                string autot = vuokrallaDG.Rows[1].Cells[1].Value.ToString();
                if (auto.Equals("Ratsuni"))
                {
                    if (tilanne.Equals("vapaa"))
                    {
                        dassePB.Visible = true;
                        dasse1PB.Visible = false;
                    }

                    else if (tilanne.Equals("varattu"))
                    {
                        dasse1PB.Visible = true;
                        dassePB.Visible = false;
                    }


                    else if (auto.Equals("Peel"))
                    {
                        if (tilanne.Equals("vapaa"))
                        {
                            peelPB.Visible = true;
                            peel1PB.Visible = false;
                        }
                        else if (tilanne.Equals("varattu"))
                        {
                            peel1PB.Visible = true;
                            peelPB.Visible = false;
                        }
                    }

                }

            }



            /* private void button1_Click(object sender, EventArgs e)
             {
                 Bitmap image = new Bitmap("C:\\Users\\mhuot\\source\\repos\\projektit\\Marko ja mika\\Autovuokra\\Auto_vuokraus\\Auto_vuokraus\\Pics\\toijoti.jpg");

                 // Käy läpi jokainen pikseli kuvassa
                 for (int y = 0; y < image.Height; y++)
                 {
                     for (int x = 0; x < image.Width; x++)
                     {
                         // Hae pikselin väri
                         Color color = image.GetPixel(x, y);

                         // Muunna väri mustavalkoiseksi
                         int gray = (int)(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                         Color newColor = Color.FromArgb(gray, gray, gray);

                         // Aseta uusi väri pikseliin
                         image.SetPixel(x, y, newColor);
                     }
                 }

                 // Tallenna uusi kuva
                 image.Save("C:\\Users\\mhuot\\source\\repos\\projektit\\Marko ja mika\\Autovuokra\\Auto_vuokraus\\Auto_vuokraus\\Pics\\toijoti1.jpg");
             }*/
        }
    }
}