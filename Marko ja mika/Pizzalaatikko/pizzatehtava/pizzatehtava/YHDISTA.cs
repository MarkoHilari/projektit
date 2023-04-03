using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace pizzatehtava
{
    internal class YHDISTA
    {
        private MySqlConnection yhdista = new MySqlConnection("datasource= localhost; port=3306; username=root; password=; database=pizzakanta");
    
        public MySqlConnection otaYhteys()
        { 
            return yhdista;
        }
        public void avaaYhteys()
        {
            if(yhdista.State == ConnectionState.Closed)
            {
                yhdista.Open();
            }
        }
        public void avaaXhteys()
        {
            if(yhdista.State == ConnectionState.Closed)
            {
                yhdista.Open();
            }
        }
        public void suljeYhteys()
        {
            if(yhdista.State == ConnectionState.Open)
            {
                yhdista.Close();
            }
        }

    }
}
