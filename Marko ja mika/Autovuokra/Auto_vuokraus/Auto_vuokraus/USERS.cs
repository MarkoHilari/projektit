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
using System.Data.SqlClient;
using Auto_vuokraus;

namespace Auto_vuokraus
{
    internal class USERS
    {
        //Yhteyksien avaaminen ja luominen, sql
        YHDISTA yhdista = new YHDISTA();
        public bool lisaaKayttaja(string id,string eNimi, string sNimi, string email,string puh, string user, string pass)//Luodaan yhteydet 
        {
            MySqlCommand cmd = new MySqlCommand();
            //string kysely = "INSERT INTO `kayttaja`(`id`,`user`,`pass`) VALUES(@id,@user,@pass)";
            string kysely = "INSERT INTO `kayttaja`(`id`, `eNimi`, `sNimi`, `email`, `puh`, `user`, `pass`) VALUES (@id,@enm,@snm,@ema,@puh,@user,@pass)";
            cmd.CommandText = kysely;
            string kt = eNimi.Substring(0, 3).ToLower() + sNimi.Substring(0, 5).ToLower();//Luodaan käyttäjätunnus
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add ("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@enm", MySqlDbType.VarChar).Value = eNimi;
            cmd.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sNimi;
            cmd.Parameters.Add("@ema", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = kt;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());//Luodaan salasana
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
        //Luodaan muokkaa käyttäjä yhteydet
        public bool muokkaaKayttaja(string id, string eNimi, string sNimi, string email, string puh, string user, string pass)
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

        public bool poistaKayttaja(string id)// Luodaan käyttäjän poiston yhteys
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

        public String luoSalasana()// Salasanan luominen 
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

        public DataTable haeKayttajat()// Käyttäjien haku
        {
            MySqlCommand komento = new MySqlCommand("SELECT `id`, `eNimi`, `sNimi`, `email`, `puh` FROM `kayttaja`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public DataTable haeKalusto()//Kaluston haku
        {
            MySqlCommand komento = new MySqlCommand("SELECT `RekisteriNro`, `Merkki`, `Malli`, `Hinta`, `vapaa` FROM `kalusto`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);

            return table;

        }
        //Asiakkaan muokkaus yhteys
        public bool muokkaaAsiakasta(int id, string enimi, string snimi, string osoite, string city, string pnro, string email, string puh )
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
        //Asiakkan lisäys yhteys
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
        public DataTable haeAsiakkaat()// Hae asiakkaat yhteys
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM `asiakkaat`", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public bool poistaAsiakas(int Aid)//Asiakkaan poistoon yhteys
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
        // Varauksen lisäämisen yhteys
        public bool lisaaVaraus(string id, string asiakas, string rknro, string merk, string malli, DateTime alku, DateTime loppu)
        {
            MySqlCommand cmd = new MySqlCommand();
            string kysely = "INSERT INTO `vuokraus`(`varausNro`, `autoRek`, `merkki`, `malli`, `asiakas`, `varauspaiva`, `varausloppu`) VALUES (@id, @rek, @mer, @mal, @asi, @alk, @lop)";
            cmd.CommandText = kysely;
            cmd.Connection = yhdista.otaYhteys();
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@asi", MySqlDbType.VarChar).Value = asiakas;
            cmd.Parameters.Add("@alk", MySqlDbType.Date).Value = alku;
            cmd.Parameters.Add("@lop", MySqlDbType.Date).Value = loppu;
            cmd.Parameters.Add("@rek", MySqlDbType.VarChar).Value = rknro;
            cmd.Parameters.Add("@mer", MySqlDbType.VarChar).Value = merk;
            cmd.Parameters.Add("@mal", MySqlDbType.VarChar).Value = malli;


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

        public DataTable haeVuokrat()// Vuokrauksien hakeminen yhteys
        {
            MySqlCommand komento = new MySqlCommand("SELECT varausNro, autoRek, merkki, malli, asiakas, varauspaiva, varausloppu FROM vuokraus ", yhdista.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);


            return table;
        }

        public bool poistaVaraus(int varausID)//Varauksen poisto yhteys
        {
            MySqlCommand komento = new MySqlCommand();
            string poistaKysely = "DELETE FROM `vuokraus` WHERE `varausNro`=@nro";
            komento.CommandText = poistaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@num
            komento.Parameters.Add("@nro", MySqlDbType.Int32).Value = varausID;

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

        public bool muokkaaVuokraus(int id, DateTime alku, DateTime loppu)//Varauksen muokkaus yhteys
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaaKysely = "UPDATE vuokraus SET varausNro=@vNro,varauspaiva=@alk,varausloppu=@lop WHERE varausNro=@vNro";
            komento.CommandText = muokkaaKysely;
            komento.Connection = yhdista.otaYhteys();
            //@id,@enimi,@snimi,@lahi,@pnro)
            komento.Parameters.Add("@vNro", MySqlDbType.Int32).Value = id;
            
            /*komento.Parameters.Add("@mer", MySqlDbType.Int32).Value = merkki;
            komento.Parameters.Add("@mal", MySqlDbType.Int32).Value = malli;
            komento.Parameters.Add("@asi", MySqlDbType.Int32).Value = asiakas;*/
            komento.Parameters.Add("@alk", MySqlDbType.Date).Value = alku;
            komento.Parameters.Add("@lop", MySqlDbType.Date).Value = loppu;
            MessageBox.Show(id + " " +loppu + " "+ alku);

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

        public bool autoVapaa(String numero, String vapaa_varattu)//Auto vapaa tai varattu yhteys
        {
            MySqlCommand komento = new MySqlCommand();
            string muokkaa = "INSERT INTO `kalusto`(`RekisteriNro`,`vapaa`) VALUES (@rek,@vap)";
            komento.CommandText= muokkaa;
            komento.Connection = yhdista.otaYhteys();
            
            

            komento.Parameters.Add("@rno", MySqlDbType.VarChar).Value = numero;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa_varattu;

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
        public String HaeSumma(String rek)// Varauksen summan hakeminen yhteys
        {
            MySqlCommand komento = new MySqlCommand("SELECT `Hinta` FROM `kalusto` WHERE `RekisteriNro`=@rek", yhdista.otaYhteys());
            /*MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = komento;
            adapter.Fill(table);

            return table;*/
            komento.Parameters.Add("@rek", MySqlDbType.VarChar).Value = rek;
            yhdista.avaaXhteys();

            MySqlDataReader lukija = komento.ExecuteReader();
            lukija.Read();
            string data = lukija.GetValue(0).ToString();
            yhdista.suljeYhteys(); 
            return data;
            
        }
    }
   
}
