using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            vuokraDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vuokraDG.DataSource = users.haeVuokrat();




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

                try
                {

                    MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=loistovuokraus");
                    string updateQuery = "UPDATE `kalusto` SET `vapaa` = @vap WHERE `RekisteriNro` = @rek";
                    con.Open();
                    MySqlCommand command = new MySqlCommand(updateQuery, con);

                    int rowCount = vuokraDG.Rows.Count;
                    
                    for (int i = 0; i < rowCount - 1; i++)
                    {
                        DataGridViewRow row = vuokraDG.Rows[i];
                        DataGridViewCell cell = row.Cells[1];
                        DataGridViewCell cell1 = row.Cells[5];
                        string rekisteriNro = cell.Value?.ToString();
                        DateTime value1 = Convert.ToDateTime(cell1.Value.ToString());

                        
                        if (value1 > DateTime.Now)
                        {
                            command.Parameters.Clear(); // Clear previously added parameters
                            command.Parameters.AddWithValue("@rek", rekisteriNro);
                            command.Parameters.AddWithValue("@vap", "vapaa");
                        }
                        else
                        {
                            command.Parameters.Clear(); // Clear previously added parameters
                            command.Parameters.AddWithValue("@rek", rekisteriNro);
                            command.Parameters.AddWithValue("@vap", "varattu");
                        }

                        command.ExecuteNonQuery();

                        bool isEmptyColumn = true;
                        for (int column = 0; column < row.Cells.Count; column++)
                        {
                            DataGridViewCell dataCell = row.Cells[column];
                            if (dataCell.Value != null && !string.IsNullOrEmpty(dataCell.Value.ToString()))
                            {
                                isEmptyColumn = false;
                                break;
                            }
                        }

                        if (isEmptyColumn)
                        {
                            // Last empty column found, break out of the loop
                            break;
                        }
                    }

                    con.Close();
                    vuokrallaDG.DataSource = users.haeKalusto();

                }


                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }

            try
            {

                MySqlConnection con = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =; database = loistovuokraus");
                string selectQuery = "SELECT * FROM asiakkaat" ;
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);
                MySqlDataReader reader = command.ExecuteReader();
                string kaikki = "";
                
                    while (reader.Read())
                {
                    kaikki = reader.GetString("sNimi");
                    kaikki += " " + reader.GetString("eNimi");
                    asijaCB.Items.Add(kaikki);
                }
            }
            catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
            }
            /*using (SqlDataReader reader = users.haeAsija())
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    asijaCB.Items.Add(value);
                }
            }*/
            
            /*asijaCB.Items.Clear(); // ei pelitä
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dataTable);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                asijaCB.Items.Add(dataRow["Asiakas"]. ToString());
            }*/


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

        private void varaaBT_Click(object sender, EventArgs e)
        {
            string id = varausNroTB.Text;
            string asiakas = asijaCB.Text;
            string rknro = rekTB.Text;
            string malli = malliTB.Text;
            string merk = merkkiTB.Text;
            DateTime alku = alkuDTM.Value;
            DateTime loppu = loppuDTM.Value;

            if (alku.Day < DateTime.Now.Day)
            {
                MessageBox.Show("Päivä pitää olla tämä päivä tai myöhempi", "Virheellinen sisäänkirjaamis päivä ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rknro.Trim().Equals("") || malli.Trim().Equals("") || merk.Trim().Equals("") || asiakas.Trim().Equals(""))
            {
                MessageBox.Show("Vaaditut kentät -  Ajoneuvo - Asiakastieto ", "lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else
            {
               string vapaako = vuokrallaDG.CurrentRow.Cells[4].Value.ToString();
                MessageBox.Show(vapaako);
                   
                if (vapaako == "vapaa" )
                {
                    Boolean lisaaVaraus = users.lisaaVaraus(id, asiakas, rknro, malli, merk, alku, loppu);

                    vuokraDG.DataSource = users.haeVuokrat();
                    

                    MessageBox.Show("Uusi varaus lisätty onnistuneesti", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uusi varaus ei lisätty onnistuneesti", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void poistavaBT_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(varausNroTB.Text);

                if (users.poistaVaraus(id))
                {
                    vuokraDG.DataSource = users.haeVuokrat();
                    MessageBox.Show("Asiakas poistettu onnistuneesti", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Asiakasta ei poistettu", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vuokraDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*varausNroTB.Text = vuokraDG.CurrentRow.Cells[0].Value.ToString();

            alkuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[5].Value);
            loppuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[6].Value);
            varausPLB.Visible = true;

            alkuDTM = alkuDTM.Value;
            loppuDTM = loppuDTM.Value;

            TimeSpan erotus = loppuDTM - alkuDTM);
            int erotusPäivissä = (int)erotus.TotalDays;

            //TimeSpan erotusPäivissä = loppuDTM.Value - alkuDTM.Value;

            varausPLB.Text = erotusPäivissä.ToString();*/

            varausNroTB.Text = vuokraDG.CurrentRow.Cells[0].Value.ToString();

            alkuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[5].Value);
            loppuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[6].Value);
            varausPLB.Visible = true;

            DateTime alkuDT = alkuDTM.Value;
            DateTime loppuDT = loppuDTM.Value;

            TimeSpan erotus = loppuDT - alkuDT;
            int erotusPaivissa = (int)erotus.TotalDays;
            loppuSummaLB.Visible = true;
            varausPLB.Text = erotusPaivissa.ToString();
            String rek = Convert.ToString(vuokraDG.CurrentRow.Cells[1].Value);
            int summa = Convert.ToInt32(users.HaeSumma(rek));
            //MessageBox.Show(summa + "");
            loppuSummaLB.Text = (int.Parse(varausPLB.Text)* summa + "€").ToString();
            vuokraDG.DataSource = users.haeVuokrat();
        }
        
        private void muokkaavarBT_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(varausNroTB.Text);
              
                DateTime alku = alkuDTM.Value;
                DateTime loppu = loppuDTM.Value;
                //id = Convert.ToInt32(varausNroTB.Text);
               
                if(alku < DateTime.Now)
                {
                    MessageBox.Show("Päivää", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (loppu < alku)
                {
                    MessageBox.Show("Helloo", "Tarks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    if(users.muokkaaVuokraus(id, alku, loppu)) 
                    {
                        MessageBox.Show("päivee", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("looiiii", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =; database = loistovuokraus");
            string insertQuery = "UPDATE `kalusto` SET `vapaa`=@vap WHERE `RekisteriNro`=@rek";
            con.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, con);

            string numero = Convert.ToString(vuokrallaDG.CurrentRow.Cells[0].Value);
            //string vapaa = Convert.ToString(vapaa_varattuGB.Checked);
            string vapaa = vapaaRB.Checked ? "Vapaa" : "Varattu";

            string varattu = varattuRB.Text;

            command.Parameters.Add("@rek", MySqlDbType.String).Value = numero;
            command.Parameters.Add("@vap", MySqlDbType.String).Value = vapaa;
            //command.Parameters.Add("@vap", MySqlDbType.String).Value = varattu;

            alkuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[5].Value);
            loppuDTM.Value = Convert.ToDateTime(vuokraDG.CurrentRow.Cells[6].Value);
            varausPLB.Visible = true;

            DateTime alkuDT = alkuDTM.Value;
            DateTime loppuDT = loppuDTM.Value;


            int rowsAffected = command.ExecuteNonQuery();

            if (vapaaRB.Checked)
            {
                MessageBox.Show("Tietue lisätty onnistuneesti.");
               
            }
            else if(varattuRB.Checked)
            {
                MessageBox.Show("Tietueen lisääminen epäonnistui.");
            }

            con.Close();
            vuokrallaDG.DataSource = users.haeKalusto();

            /*MySqlConnection con = new MySqlConnection("datasource = localhost; port = 3306; username = root; password =; database = loistovuokraus");
            string selectQuery = "INSERT INTO `kalusto`(`RekisteriNro`,`vapaa`) VALUES (@rek,@vap)";
            con.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, con);

            string numero = Convert.ToString(vuokrallaDG.CurrentRow.Cells[0].Value);
            string vapaa = vapaaRB.Text;
            string varattu = varattuRB.Text;

            command.Parameters.Add("@rek", MySqlDbType.String).Value = numero;
            command.Parameters.Add("@vap", MySqlDbType.String).Value = vapaa;
            if(vapaaRB.Checked)
            {
                vapaa = "Vapaa";
                MessageBox.Show(numero + " " + vapaa);
            }
            else if(varattuRB.Checked)
            {
                varattu = "Varattu";
                MessageBox.Show(numero + " " + varattu);
            }*/

            /*string vapaa = varattuRB.Text;
            string vapaa_varattu = "";

            if (users.autoVapaa(vapaa, vapaa_varattu))
            {
                MessageBox.Show("kukkuu");
                users.autoVapaa(vapaa, vapaa_varattu);            
            }
            else
            {
                button1.Text = "OK";
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        { }
    }
}