using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// HEAD


namespace Hotellitehtävä
{
    internal class YHDISTA
    {
        public string muodostaYhteys()
        {
            return "datasource = sql7.freesqldatabase.com;Port = 3306;username = sql7603897;password = vQdhASH2tU;database = sql7603897";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource = sql7.freesqldatabase.com;Port = 3306;username = sql7603897;password = vQdhASH2tU;database = sql7603897");
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
