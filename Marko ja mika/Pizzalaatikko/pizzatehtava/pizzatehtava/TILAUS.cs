using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Data.SqlClient;

namespace pizzatehtava
{
    internal class TILAUS
    {
        YHDISTA yhdista = new YHDISTA();
        
        public DataTable haeTilaukset()
        {
            MySqlCommand pyynto = new MySqlCommand("SELECT * FROM `ostoskori`", yhdista.otaYhteys());
            MySqlDataAdapter sovitin = new MySqlDataAdapter();
            DataTable data = new DataTable();

            sovitin.SelectCommand = pyynto;
            sovitin.Fill(data);
            return data;

        }
        public bool lisaaTilaus(string tuote)
        {
            MessageBox.Show(tuote + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO ostoskori (nimike, hinta) SELECT nimike, hinta FROM tuotteet WHERE nimike = @tuo";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
           
            pyynto.Parameters.Add("@tuo", MySqlDbType.VarChar).Value = tuote;
            //pyynto.Parameters.Add("@hin", MySqlDbType.VarChar).Value = hinta;

            yhdista.avaaXhteys();
            
            if(pyynto.ExecuteNonQuery() == 1)
            {
                yhdista.suljeYhteys();
                return true;
            }
            else
            {
                yhdista.suljeYhteys();
                return false;
            }
        }


        public bool poistaTilaus(string tuote)
        {
            MessageBox.Show(tuote + "Poistettu ostoskorista");
            MySqlCommand pyynto = new MySqlCommand();
            string poistoKysely = "DELETE FROM `ostoskori` WHERE `nimike` = @tuo";
            pyynto.CommandText = poistoKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@tuo", MySqlDbType.VarChar).Value = tuote;
            yhdista.avaaXhteys();
            if (pyynto.ExecuteNonQuery() == 1)
            {
                yhdista.suljeYhteys();
                return true;
            }
            else
            {
                yhdista.suljeYhteys();
                return false;
            }
        }
        public bool poistaKokoTilaus(string nimike)
        {
            MessageBox.Show("Ostoskori tyhjennetty");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "DELETE FROM `ostoskori`";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@nim", MySqlDbType.VarChar).Value = nimike;
            yhdista.avaaXhteys();
            
            if (pyynto.ExecuteNonQuery() == 1)
            {
                yhdista.suljeYhteys();
                return true;
            }
            else
            {
                yhdista.suljeYhteys();
                return false;
            }
        }
        public string haeSumma()
        {
            string summa = "0";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand pyynto = new MySqlCommand();
            String kysely = "SELECT SUM(hinta) AS yhthinta from ostoskori";

            pyynto.CommandText=kysely;
            pyynto.Connection = yhdista.otaYhteys();

            adapter.SelectCommand = pyynto;
            adapter.Fill(table);
            if(table.Rows.Count > 0 )
            {
                summa = table.Rows[0]["yhthinta"].ToString();
            }

            //SELECT SUM(hinta) from ostoskori
            return summa;
        }

    }
}
