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
           


            string makkara = vuokrallaDG.Rows[0].Cells[1].Value.ToString();
            string ford = vuokrallaDG.Rows[1].Cells[1].Value.ToString();
            string toyoti = vuokrallaDG.Rows[2].Cells[1].Value.ToString();
            string mosse = vuokrallaDG.Rows[3].Cells[1].Value.ToString();
            string peel = vuokrallaDG.Rows[4].Cells[1].Value.ToString();
            string dasse = vuokrallaDG.Rows[5].Cells[1].Value.ToString();

            string tilanne = vuokrallaDG.Rows[0].Cells[4].Value.ToString();
            string tilanne1 = vuokrallaDG.Rows[1].Cells[4].Value.ToString();
            string tilanne2 = vuokrallaDG.Rows[2].Cells[4].Value.ToString();
            string tilanne3 = vuokrallaDG.Rows[3].Cells[4].Value.ToString();
            string tilanne4 = vuokrallaDG.Rows[4].Cells[4].Value.ToString();
            string tilanne5 = vuokrallaDG.Rows[5].Cells[4].Value.ToString();

            if (dasse.Equals("Ratsuni"))
                {
                    if (tilanne5.Equals("vapaa"))
                    {
                        dassePB.Visible = true;
                        dasse1PB.Visible = false;
                    }

                    else if (tilanne5.Equals("varattu"))
                    {
                        dasse1PB.Visible = true;
                        dassePB.Visible = false;
                    }


                if (peel.Equals("Peel"))
                {
                        if (tilanne4.Equals("vapaa"))
                        {
                            peelPB.Visible = true;
                            peel1PB.Visible = false;
                        }
                        else if (tilanne4.Equals("varattu"))
                        {
                            peel1PB.Visible = true;
                            peelPB.Visible = false;
                        }
                }
                if (makkara.Equals("Sausage"))
                {
                    if (tilanne.Equals("vapaa"))
                    {
                        sausagePB.Visible = true;
                        sausage1PB.Visible = false;
                    }
                    else if (tilanne.Equals("varattu"))
                    {
                        sausage1PB.Visible = true;
                        sausagePB.Visible = false;
                    }
                }
                if (mosse.Equals("Mosse"))
                {
                    if (tilanne3.Equals("vapaa"))
                    {
                        mossePB.Visible = true;
                        mosse1PB.Visible = false;
                    }
                    else if (tilanne3.Equals("varattu"))
                    {
                        mosse1PB.Visible = true;
                        mossePB.Visible = false;
                    }
                }
                if (ford.Equals("Ford"))
                {
                    if (tilanne1.Equals("vapaa"))
                    {
                        fordPB.Visible = true;
                        fordPB1.Visible = false;
                    }
                    else if (tilanne1.Equals("varattu"))
                    {
                        fordPB1.Visible = true;
                        fordPB.Visible = false;
                    }
                }
                if (toyoti.Equals("Toyota"))
                {
                    if (tilanne2.Equals("vapaa"))
                    {
                        toyotaPB.Visible = true;
                        toyota1PB.Visible = false;
                    }
                    else if (tilanne2.Equals("varattu"))
                    {
                        toyota1PB.Visible = true;
                        toyotaPB.Visible = false;
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

        private void vuokrallaDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rekTB.Text = vuokrallaDG.CurrentRow.Cells[0].Value.ToString();
            malliTB.Text = vuokrallaDG.CurrentRow.Cells[2].Value.ToString();
            merkkiTB.Text = vuokrallaDG.CurrentRow.Cells[1].Value.ToString();
        }
    }
}