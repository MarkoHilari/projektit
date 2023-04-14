using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace pizzatehtava
{
    internal class TILAUS
    {
        YHDISTA yhdista = new YHDISTA();
        public DataTable haeTilaukset()     //  Komento jolla haetaan SQL tietokannasta tuotteet datagridille
        {
            MySqlCommand pyynto = new MySqlCommand("SELECT * FROM `ostoskori`", yhdista.otaYhteys());
            MySqlDataAdapter sovitin = new MySqlDataAdapter();
            DataTable data = new DataTable();

            sovitin.SelectCommand = pyynto;
            sovitin.Fill(data);
            return data;

        }
        public bool lisaaTilaus(string pizza)      // Pizzan lisääminen SQL tietokantaan ja datagridille
        {                                           // Yhteyden avaaminen aluksi ja sitten sulku
            MessageBox.Show(pizza + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `ostoskori`(`nimike`) VALUES (@pit)";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
           
            pyynto.Parameters.Add("@pit", MySqlDbType.VarChar).Value = pizza;
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

        public bool poistaTilaus(string pizza)    // Tuotteiden poistaminen datagridistä ja SQL tietokannasta
        {
            MessageBox.Show(pizza + "Poistettu ostoskorista");
            MySqlCommand pyynto = new MySqlCommand();
            string poistoKysely = "DELETE FROM `ostoskori` WHERE `nimike` = @pit";
            pyynto.CommandText = poistoKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@pit", MySqlDbType.VarChar).Value = pizza;
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
        public bool lisaaJuoma(string juoma)   // Juoman lisääminen SQL tietokantaan. Yhteyden avaaminen aluksi ja sitten sulku
        {
            MessageBox.Show(juoma + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `ostoskori`(`nimike`) VALUES (@juo)";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@juo", MySqlDbType.VarChar).Value = juoma;
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
       
    }
}
