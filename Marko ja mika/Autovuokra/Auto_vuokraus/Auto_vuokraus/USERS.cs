﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Eramake;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Auto_vuokraus
{
    internal class USERS
    {

        YHDISTA yhdista = new YHDISTA();
        public bool lisaaKayttaja(string id,string eNimi, string sNimi, string email,string puh, string user, string pass)
        {
            MySqlCommand cmd = new MySqlCommand();
            //string kysely = "INSERT INTO `kayttaja`(`id`,`user`,`pass`) VALUES(@id,@user,@pass)";
            string kysely = "INSERT INTO `kayttaja`(`id`, `eNimi`, `sNimi`, `email`, `puh`, `user`, `pass`) VALUES (@id,@enm,@snm,@ema,@puh,@user,@pass)";
            cmd.CommandText = kysely;
            string kt = eNimi.Substring(0, 3).ToLower() + sNimi.Substring(0, 5).ToLower();
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add ("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = eNimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sNimi;
            cmd.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = kt;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
            MessageBox.Show("käyttäjätunnus: " + " " + kt + "Salasanasi: " + " " + luoSalasana());
            

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

        public bool muokkaaKayttaja(string id, string eNimi, string sNimi, string email, string puh, string user, string pass)// VIELÄ KESKEN, POHJA VALMIINA
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE `kayttaja` SET `eNimi`=@enm,`sNimi`=@snm,`email`=@ema,`puh`=@puh,`user`=@user,`pass`=@pass WHERE id= @id";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@id,@enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = eNimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sNimi;
            komento.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            //MessageBox.Show(id + " " + enimi + " " + snimi + " " + osoite + " " + city + " " + pnro + " " + email + " " + puh);

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

        public bool poistaKayttaja(string id)
        {
            MySqlCommand cmd = new MySqlCommand();
            string poista = "DELETE FROM `kayttaja` WHERE id=@id";
            cmd.CommandText = poista;
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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

        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }

        public DataTable haeKayttajat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT `id`, `eNimi`, `sNimi`, `email`, `puh` FROM `kayttaja`", yhdista.otaYhteys());
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
            string muokkaaKysely = "UPDATE asiakkaat SET eNimi=@enm,sNimi=@snm,osoite=@oso,city=@cit,pnro=@pno,email=@ema,puh=@puh WHERE asiakasId= @id";
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
            //MessageBox.Show(id + " " + enimi + " " + snimi + " " + osoite + " " + city + " " + pnro + " " + email + " " + puh);

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

        public bool poistaAsiakas(int Aid)
        {
            MySqlCommand komento = new MySqlCommand();
            string poista = "DELETE FROM `asiakkaat` WHERE `asiakasID`= @id";
            komento.CommandText = poista;
            komento.Connection = yhdista.otaYhteys();
            komento.Parameters.Add("@id", MySqlDbType.Int32).Value = Aid;

            yhdista.avaaXhteys();

            if(komento.ExecuteNonQuery() == 1)
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
        /*public bool haeasija()
        {
            MySqlCommand cmd = new MySqlCommand();
            string lisaa = 
        }*/
    }
}
