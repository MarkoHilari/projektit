using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Auto_vuokraus
{
    internal class USERS
    {

        YHDISTA yhdista = new YHDISTA();
        public bool lisaaKayttaja(string id,string user, string pass)
        {
            MySqlCommand cmd = new MySqlCommand();
            string kysely = "INSERT INTO `kayttaja`(`id`,`user`,`pass`) VALUES(@id,@user,@pass)";
            cmd.CommandText = kysely;
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add ("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            yhdista.avaaXhteys();
            if (cmd.ExecuteNonQuery() == 1)
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

        public DataTable haeKayttajat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `kayttaja`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public DataTable haeKalusto()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `RekisteriNro`, `Merkki`, `Malli`, `Hinta`, `vapaa` FROM `kalusto`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);

            return table;

        }

        public bool muokkaaAsiakasta(int id, string enimi, string snimi, string osoite, string city, string pnro, string email, string puh )// VIELÄ KESKEN, POHJA VALMIINA
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE `asiakkaat` SET eNimi='@enm',sNimi='@snm',osoite='@oso',city='@cit',pnro='@pno',email='@ema',puh='@puh' WHERE asiakasId= '@id'";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@id,@enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@cit", MySqlDbType.VarChar).Value = city;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            MessageBox.Show(id + " " + enimi + " " + snimi + " " + osoite + " " + city + " " + pnro + " " + email + " " + puh);

            yhdista.avaaXhteys();

            if (komento.ExecuteNonQuery() == 1)
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
        public bool lisaaAsiakas(string id,string enimi,string snimi,string osoite,string city,string pnro,string email,string puh)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisaaKysely = "INSERT INTO `asiakkaat`(`asiakasId`, `eNimi`, `sNimi`, `osoite`, `city`, `pnro`, `email`, `puh`) VALUES (@id,@enm,@snm,@oso,@cit,@pno,@ema,@puh)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yhdista.otaYhteys();
            // '@id','@enm','@snm','@oso','@cit','@pno','@ema','@puh'
            komento.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@cit", MySqlDbType.VarChar).Value = city;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;

            yhdista.avaaXhteys();

            if (komento.ExecuteNonQuery() == 1)
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
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `asiakkaat`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }
    }
}
