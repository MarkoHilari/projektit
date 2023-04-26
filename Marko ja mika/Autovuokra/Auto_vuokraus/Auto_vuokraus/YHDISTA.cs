using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Auto_vuokraus
{

    internal class YHDISTA      // yhteys sql0
    {
        private MySqlConnection yhdista = new MySqlConnection("datasource= localhost;port=3306;username=root;password=;database=loistovuokraus");

        public MySqlConnection otaYhteys()
        {
            return yhdista;
        }

        public void avaaXhteys()    // yhteyden avaaminen sql
        {
            if (yhdista.State == ConnectionState.Closed)
            {
                yhdista.Open();
            }
        }
        public void suljeYhteys()     // yhteyden sullkeminen sqlaaaaaan
        {
            if (yhdista.State == ConnectionState.Open)
            {
                yhdista.Close();
            }
        }

    }
}
