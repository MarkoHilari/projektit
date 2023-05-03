using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_vuokraus
{
    internal class USERS
    {
        YHDISTA yhdista = new YHDISTA();
        public bool lisaaKayttaja(string id, string user, string pass)
        {
            MySqlCommand cmd = new MySqlCommand();
            string kysely = "INSERT INTO `kayttaja`(`id`, `user`, `pass`) VALUES('@id', '@user', '@pass')";
            cmd.CommandText = kysely;
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add = ("id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add = ("user", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add = ("pass", MySqlDbType.VarChar).Value = pass;

            yhdista.avaaXhteys();
            if (cmd.ExecuteNonQuery() = 1)
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
