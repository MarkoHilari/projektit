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
        ostoskori OK = new ostoskori();
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
        /*public bool lisaaJuoma(string tuote)
        {
            MessageBox.Show(tuote + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO ostoskori (nimike, hinta) SELECT nimike, hinta FROM tuotteet WHERE nimike = @tuo";
            pyynto.CommandText = lisaaKysely;
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
        }*/
        public  void haeSumma()
        {
            YHDISTA yhdista = new YHDISTA();
            DataTable Table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT SUM(hinta) from ostoskori";
            command.CommandText = query;
            command.Connection = yhdista.otaYhteys();
            adapter.SelectCommand = command;
            adapter.Fill(Table);

            if(Table.Rows.Count > 0)
            {
                
            }

            /*//String vastaus  = "100 €";
            MySqlCommand pyynto = new MySqlCommand("SELECT SUM(hinta) from ostoskori", yhdista.otaYhteys());
            MySqlDataAdapter sovitin = new MySqlDataAdapter();
            DataTable data = new DataTable();
            /*MySqlDataReader data;
            data = pyynto.ExecuteReader();
            while (data.Read())
            {
                vastaus = data[0].ToString(); 
            }
            /*sovitin.SelectCommand = pyynto;
            sovitin.Fill(data);
            return data;

            //SELECT SUM(hinta) from ostoskori*/

        }

    }
}
