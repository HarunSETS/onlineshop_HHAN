using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //potrebno zbog procedura koje dohvataju ili mijenjaju podatke u MySQL bazi
using System.Drawing; // potrebno zbog ModificirajGridView

namespace prodaja_HHAN
{
    static class Program
    {

        // NA NIVOU KLASE GLAVNOG PROGARMA ĆEMO ČUVATI PODATKE I KREIRATI NEKE FUNKCIJE
        // KOJE ĆEMO KORISTITI NA VIŠE MJESTA U PROGRAMU (NA PRIMJER NA RAZLIČITIM FORMAMA)
        // DETALJNIJE JE OPISANO U NASTAVKU...
        

        // Konekcioni string:
        // ==================================================

        public static string konekcioniString = "Server=localhost; Port=3306; Database=prodaja_hhan_iv2; Uid=root; Pwd=nurah";

        
        // Podaci o prijavljenom korisniku:
        // ==================================================
        
        public static string prijavljeniKupacID;        //  <=========  ID prijavljenog korisnika
        public static string tipPrijavljenogKupca;      //  <=========  tip prijavljenog korisnika (administrator ili kupac)
        public static string kupacInfoPrikaz;           //  <=========  informacija o prijavljenom kupcu koja se vidi na svim ekranima  

        
        // Forme u aplikaciji
        // ==================================================

        // Da se ne bi kreirali višestruke objekti za iste forme svaka forma će biti kreirana maksimalno samo kao jedan objekat 
        // (npr. frLogin, frAdmGlavna, frAdmArtikli, ...)
        // Odgovarajuće forme (objekti formi) će se kreirati, prikazivati i sakrivati prema potrebi.
        // Na primjer frAdmGlavna, frAdmArtikli, frAdmKupaca, frAdmNarudzbi će se kreirati svaki put ponovo na login formi ako je prijavljeni korisnik administrator, a nakon odjave će biti zatvorene.
        // Slično, forme frKupGlavna, frKupKreiranjeNarudzbe i frKupPregledNarudzbi će se kreirati svaki put ponovo na login formi ako je prijavljeni korisnik kupac, a nakon odjave će biti zatvorene.
        // Jedina forma koja se neće više puta kreirati i zatvarati, već će se samo sakrivati i prikazivati je login forma frLogin

        public static FormLogin frLogin;

        public static FormAdmGlavna frAdmGlavna;
        public static FormAdmArtikala frAdmArtikli;
        public static FormAdmKupaca frAdmKupaca;
        public static FormAdmNarudzbi frAdmNarudzbi;

        public static FormKupGlavna frKupGlavna;
        public static FormKupKreiranjeNarudzbe frKupKreiranjeNarudzbe;
        public static FormKupPregledNarudzbi frKupPregledNarudzbi;


        // Procedura Odjava()
        // ==================================================

        // Ova procedura se koristi na više mjesta u programu i obezbjeđuje da se prethodno kreirane forme zatvore
        // tako da se prilikom novih prijava forme ponovo kreiraju i tako spriječi da na njima ostanu podaci sa ranijih prijava.

        public static void Odjava()
        {
            MessageBox.Show(kupacInfoPrikaz + " bićete odjavljeni iz aplikacije. Želimo Vam ugodan dan.");
            
            // Ako su forme koje čuvamo na nivou programa bile kreirane zatvaramo ih (nakon uspješne prijave odgovarajuće forme će ponovo kreirati login forma)
            
            // Ove forme su trebale biti kreirane ako je prethodna prijava bila za administratora
            
            if (frAdmGlavna != null)
                frAdmGlavna.Dispose();
            if (frAdmArtikli != null)
                frAdmArtikli.Dispose();
            if (frAdmKupaca != null)
                frAdmKupaca.Dispose();
            if (frAdmNarudzbi != null)
                frAdmNarudzbi.Dispose();

            // Ove forme su trebale biti kreirane ako je prethodna prijava bila za kupca
            
            if (frKupGlavna != null)
                frKupGlavna.Dispose();
            if (frKupKreiranjeNarudzbe != null)
                frKupKreiranjeNarudzbe.Dispose();
            if (frKupPregledNarudzbi != null)
                frKupPregledNarudzbi.Dispose();

            // Čistimo varijable o korisniku koje čuvamo na nivou programa
            
            prijavljeniKupacID = "";
            tipPrijavljenogKupca = "";
            kupacInfoPrikaz = "";

            // A zatim ponovo otkrivamo formu za login
            
            frLogin.Show();
        }


        // Neke procedure za rad s bazom podataka
        // ==================================================

        // Slijede neke funkcije vezane za rad s bazom (dohvatanje, insert, update ili delete podataka)
        // koje se koriste na više mjesta u programu


        // ======== stanje na skladištu i artikli

        public static int vratiKolicinuArtiklaNaSkladistu (int artiklID)
        {
            // vraća količinu artikla <artiklID> u skladištu   

            int rezultat;

            string upit = " select kolicina_stanje from skladiste" +
                          " where artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                rezultat = System.Convert.ToInt32(reader["kolicina_stanje"].ToString());
            else
                rezultat = 0;

            reader.Close();
            con.Close();

            return rezultat;
        }

        public static void updatePovecajKolicunuArtiklaUSkladistu(int artiklID, int dodajKolicinu)
        {
            // povećava količinu artikla <artiklID> u skladištu za vrijednost <dodajKolicinu>
            
            string upit = " update skladiste set kolicina_stanje = kolicina_stanje + " + dodajKolicinu +
                          " where artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void updatePostaviKolicinuArtiklaUSkladistu(int artiklID, int kolicina)
        {
            // postavlja količinu artikla <artiklID> u skladištu za vrijednost <kolicina>
            
            string upit = " update skladiste set kolicina_stanje = " + kolicina +
                          " where artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // ======== stavke narudžbe i artikli

        public static int vratiKolicinuArtiklaUNarudzbi(int narudzbaID, int artiklID)
        {
            // vraća količinu artikla <artiklID> iz stavki narudzbe <narudzbaID>

            int rezultat;

            string upit = " select kolicina from stavke_narudzbenica" +
                          " where narudzbenica_id = " + narudzbaID + " and artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
                rezultat = System.Convert.ToInt32(reader["kolicina"].ToString());
            else
                rezultat = 0;

            reader.Close();
            con.Close();

            return rezultat;
        }

        public static void updatePostaviKolicinuArtiklaUNarudzbi(int narudzbaID, int artiklID, int kolicina)
        {
            // u narudžbi <narudzbaID> na stavci koja se odnosi na artikl <artiklID> postavlja količinu na <kolicina>

            string upit = " update stavke_narudzbinica set kolicina = " + kolicina +
                          " where narudzbenica_id = " + narudzbaID + " and artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void insertArtiklaUNarudzbu(int narudzbaID, int artiklID, int kolicina)
        {
            // u narudžbu <narudzbaID> insertuje stavku za artikl (artiklID) sa količinom <kolicina>
            // (polje stavka_id se ne šalje jer njega baza kreira sama kao autoincrement)
            
            string upit = " insert into stavke_narudzbinica(narudzbenica_id, artikal_id, kolicina)" +
                          " values (" + narudzbaID + ", " + artiklID + ", " + kolicina + ")";

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void deleteArtiklaUNarudzbi(int narudzbaID, int artiklID)
        {
            // briše stavki narudžbe <narudzbaID> briše onu stavku koja se odnosi na artikl <artiklID>

            string upit = " delete from stavke_narudzbinica" + 
                          " where narudzbenica_id = " + narudzbaID + " and artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // ======== zaglavlje narudzbe

        public static void insertNarudzbe(int kupacID)
        {
            // kreira novo zaglavlje narudžbe za kupca <kupacID> na trenutni datum koji odredi baza podataka (baza koristi funkciju now() )
            // (polje narudzbenica_id se ne šalje jer njega baza kreira sama kao autoincrement)

            string upit = " insert into narudzbinice(kupac_id, datum_narudzbe)" +
                          " values (" + kupacID + ", now() )";

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void obrisiNarudzbuINjeneStavke(int narudzbaID)
        {
            // najprije briše sve stavke narudžbe <narudzbaID>, a potom obriše i samo zaglavlje narudžbe <narudzbaID>

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();

            string upit = " delete from stavke_narudzbinica" +
                          " where narudzbenica_id = " + narudzbaID;

            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();

                   upit = " delete from narudzbe" +
                          " where narudzbenica_id = " + narudzbaID;

            MySqlCommand cmd2 = new MySqlCommand(upit, con);
            cmd2.ExecuteNonQuery();            
            
            con.Close();
        }


        // ======== kupci (korisnici)

        public static void insertKupca(string user, string pass, string tipKorisnikaID, string ime, string prezime, string grad, string adresa, string telefon)
        {
            // kreira novog kupca
            // (polje kupac_ID se ne šalje jer njega baza kreira sama kao autoincrement)

            string upit = " insert into kupci(user, pass, tip_korisnika_id, ime, prezime, grad, adresa, telefon)" +
                          " values ('" + user + "', '" + pass + "', '" + tipKorisnikaID + "', '" + ime + "', '" + prezime + "', '" + grad + "', '" + adresa + "', '" + telefon + "')";

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void updateKupca(int kupacID, string user, string pass, string tipKorisnikaID, string ime, string prezime, string grad, string adresa, string telefon)
        {
            // ažurira podatke o kupcu <kupacID>

            string upit =   " update kupci set" +
                            "   user = '" + user + "'," +
                            "   pass = '" + pass + "'," +
                            "   tip_korisnika_id = '" + tipKorisnikaID + "'," +
                            "   ime = '" + ime + "'," +
                            "   prezime = '" + prezime + "'," +
                            "   grad = '" + grad + "'," +
                            "   adresa = '" + adresa + "'," +
                            "   telefon = '" + telefon + "'" +
                            " where kupac_id = " + kupacID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // ======== artikli 

        public static void insertArtikla(string barKod, string nazivArtikla, string vrstaArtikla, double cijena)
        {
            // kreira novi artikl
            // (polje artikal_ID se ne šalje jer njega baza kreira sama kao autoincrement)

            string upit = " insert into artikli(bar_kod, naziv_artikla, vrsta_artikla, cijena)" +
                          " values ('" + barKod + "', '" + nazivArtikla + "', '" + vrstaArtikla + "', " + cijena + ")";

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void updateArtikla(int artiklID, string barKod, string nazivArtikla, string vrstaArtikla, double cijena)
        {
            // ažurira podatke o kupcu <kupacID>

            string upit = " update artikli set" +
                            "   bar_kod = '" + barKod + "'," +
                            "   naziv_artikla = '" + nazivArtikla + "'," +
                            "   vrsta_artikla = '" + vrstaArtikla + "'," +
                            "   cijena = " + cijena +
                            " where artikal_id = " + artiklID;

            MySqlConnection con = new MySqlConnection(konekcioniString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(upit, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Druge razne korisne procedure
        // ==================================================

        public static void ModificirajGridView(DataGridView dgv)
        {
            // Funckija postavlja parne redove datagridview kontrole u sivu, 
            // a neparne u bijelu boju
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows.IndexOf(dgv.Rows[i]) % 2 == 0)
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                else
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }



        // GLAVNI (MAIN) PROGRAM - Poziv login forme
        // ==================================================
        // ==================================================

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frLogin = new FormLogin();
            Application.Run(frLogin);
        }

        
    }
}
