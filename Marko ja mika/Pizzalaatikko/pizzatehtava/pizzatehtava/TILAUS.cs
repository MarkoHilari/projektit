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
        public DataTable haeTilaukset()
        {
            MySqlCommand pyynto = new MySqlCommand("SELECT * FROM `ostoskori`", yhdista.otaYhteys());
            MySqlDataAdapter sovitin = new MySqlDataAdapter();
            DataTable data = new DataTable();

            sovitin.SelectCommand = pyynto;
            sovitin.Fill(data);
            return data;

        }
        public bool lisaaTilaus(string pizza)
        {
            MessageBox.Show(pizza + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `ostoskori`(`pizza`) VALUES (@pit)";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@pit", MySqlDbType.VarChar).Value = pizza;
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


        public bool poistaTilaus(string pizza)
        {
            MessageBox.Show(pizza + "Poistettu ostoskorista");
            MySqlCommand pyynto = new MySqlCommand();
            string poistoKysely = "DELETE FROM `ostoskori` WHERE `pizza` = @pit";
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
        public bool lisaaJuoma(string juoma)
        {
            MessageBox.Show(juoma + " " + "Lisätty ostoskoriin");
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `ostoskori`(`juoma`) VALUES (@juo)";
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
