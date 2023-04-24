﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Auto_vuokraus
{

    internal class YHDISTA      // yhteys sql
    {
        private MySqlConnection yhdista = new MySqlConnection("datasource= localhost; port=3306; username=root; password=; database=pizzakanta");

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
        public void suljeYhteys()     // yhteyden sullkeminen sql
        {
            if (yhdista.State == ConnectionState.Open)
            {
                yhdista.Close();
            }
        }

    }
}