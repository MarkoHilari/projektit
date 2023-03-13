using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellitehtävä
{
    class ASIAKAS
    {
        YHDISTA yhteys = new YHDISTA();
        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand cmd = new MySqlCommand();
            String lisayskysely = "INSERT INTO Työntekijät " +
                "(ktunnus, etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, salasana) " +
                "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            cmd.CommandText = lisayskysely;
            cmd.Connection = yhteys.otaYhteys();
            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            cmd.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            if(kayttaja !="")
            {
                cmd.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                cmd.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if(ssana != "")
            {
                cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ssana;
            }
            else
            {
                cmd.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = "xcxcRT6!2@";
            }

            yhteys.avaaYhteys();
            if(cmd.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public DataTable haeAsiakkaat()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT etunimi, sukunimi, lahisoite, postinumero, postitoimipaikka, ktunnus FROM Työntekijät", yhteys.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(taulu);

            return taulu;
        }
        public bool muokkaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand cmd = new MySqlCommand();
            String kysely = "UPDATE Työntekijät SET etunimi = @enm, " +
                "sukunimi = @snm, lahiosoite = @oso, postinumero = @ pno, postitoimpipaikka = @ptp" +
                "WHERE ktunnus = @ktu";
            cmd.CommandText = kysely;
            cmd.Connection = yhteys.otaYhteys();
            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value= enimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            cmd.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            cmd.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            cmd.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();
            if (cmd.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand cmd = new MySqlCommand();
            String poistoKysely = "DELETE FROM Työntekijät WHERE ktunnus = @ktu";
            cmd.CommandText = poistoKysely;
            cmd.Connection = yhteys.otaYhteys();
            cmd.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

            yhteys.avaaYhteys();
            if(cmd.ExecuteNonQuery()==1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
