using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prodaja_HHAN
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void prijava()
        {
            errorProvider.Clear();

            String korisnickoIme = textBoxKorisnickoIme.Text.Trim();

            String query = 
                " select k.kupac_id, k.pass, k.tip_korisnika_id, concat(k.ime, ' ', k.prezime) as ime_prezime, t.pozdravna_poruka, t.naziv as naziv_tipa_korisnika" +
                " from kupci k, tipovi_korisnika t" +
                " where k.tip_korisnika_id = t.tip_korisnika_id and k.user = '" + korisnickoIme + "' ";
            try
            {
                MySqlConnection kon = new MySqlConnection(Program.konekcioniString);

                kon.Open();

                MySqlCommand cmd = new MySqlCommand(query, kon);

                MySqlDataReader reader;

                reader = cmd.ExecuteReader();

                reader.Read();

                if (!reader.HasRows)
                {
                    // ako nema reda znači da korisnik sa tim username-om ne postoji
                    errorProvider.SetError(textBoxKorisnickoIme, "Pogrešno korisničko ime!");
                }
                else
                {
                    // korisnik postoji

                    Program.prijavljeniKupacID = reader["kupac_id"].ToString();
                    Program.tipPrijavljenogKupca = reader["tip_korisnika_id"].ToString();

                    String sifraIzBaze = reader["pass"].ToString();
                    String imeIPrezime = reader["ime_prezime"].ToString();
                    String pozdravnaPoruka = reader["pozdravna_poruka"].ToString();
                    String nazivTipaKorisnika = reader["naziv_tipa_korisnika"].ToString();

                    // Ako je unesen dobar pasword
                    if (sifraIzBaze == textBoxSifra.Text)
                    {
                       
                        Program.kupacInfoPrikaz = imeIPrezime + "  (" + nazivTipaKorisnika + ")";

                        if (Program.tipPrijavljenogKupca == "ADM")
                        {
                            // Ako je prijavljeni korisnik administrator pozdravljamo ga uz pojašnjenje šta može da uradi
                            MessageBox.Show("Dobro došli " + imeIPrezime + ". " + pozdravnaPoruka);
                            
                            // kreiramo samo 4 forme koje koriste administratori
                            Program.frAdmGlavna = new FormAdmGlavna();
                            Program.frAdmArtikli = new FormAdmArtikala();
                            Program.frAdmKupaca = new FormAdmKupaca();
                            Program.frAdmNarudzbi = new FormAdmNarudzbi();

                            // sakrivamo login formu i otkrivamo glavnu formu za administratore                            
                            this.Hide();
                            Program.frAdmGlavna.Show();                            
                        }
                        else if (Program.tipPrijavljenogKupca == "KUP")
                        {
                            // Ako je prijavljeni korisnik kupac pozdravljamo ga uz pojašnjenje šta može da uradi
                            MessageBox.Show("Dobro došli " + imeIPrezime + ". " + pozdravnaPoruka);

                            // kreiramo samo 3 forme koje koriste kupci
                            Program.frKupGlavna = new FormKupGlavna();
                            Program.frKupKreiranjeNarudzbe = new FormKupKreiranjeNarudzbe();
                            Program.frKupPregledNarudzbi = new FormKupPregledNarudzbi();

                            // sakrivamo login formu i otkrivamo prikazujemu glavnu formu za kupce
                            this.Hide();
                            Program.frKupGlavna.Show();
                        }
                        else
                        {
                            // Za eventualne ostale tipove korisnika (koji nisu administratori ili kupci) javljamo da trenutno nisu podržane
                            MessageBox.Show("Vaša uloga " + nazivTipaKorisnika + " nije trenutno podržana! Molimo da se obratite timu HHAN koji razvija aplikaciju. :)");
                        }

                        //Počistimo sadržaj textboxa u kojem se čuva šifra tako da kad se nakon odjave login forma ponovo otkrije ovo polje bude prazno
                        textBoxSifra.Text = "";

                    }
                    // U suprotnom unešen je pogrešan password prilikom logovanja
                    else
                    {
                        errorProvider.SetError(textBoxSifra, "Pogrešana šifra!");
                    }
                }

                reader.Close();

                kon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            prijava();
        }

        private void textBoxSifra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                prijava();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
