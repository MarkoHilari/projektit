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
            MySqlAdapter sovitin = new MySqlAdapter();
            DataTable data = new DataTable();

            sovitin.SelectCommand = pyynto;
            sovitin.Fill(data);
            return data;

        }
    }
}
