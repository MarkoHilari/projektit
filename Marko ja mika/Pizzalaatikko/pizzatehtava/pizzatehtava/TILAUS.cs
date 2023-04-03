using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

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
        public bool lisaaTilaus(int pizza)
        {
            MySqlCommand pyynto = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `ostoskori`(`pizza`) VALUES ('@pit')";
            pyynto.CommandText = lisaaKysely;
            pyynto.Connection = yhdista.otaYhteys();
            pyynto.Parameters.Add("@pit", MySqlDbType.Int32).Value = pizza;
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
    }
}
