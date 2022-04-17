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
    public partial class FormKupKreiranjeNarudzbe : Form
    {

        /*
        --------------------------------
            kolone u dataGridViewArtikli

            ponudaArtikalID
            ponudaArtikalNaziv
            ponudaCijenaArtikalKomad
            ponudaArtikalKolicina           -- stanje artikla na skladištu

        --------------------------------
            kolone u dataGridViewKorpa

            korpaArtikalID
            korpaArtikalNaziv
            korpaCijenaArtikalKomad
            korpaOduzmi1Komad               -- ovo je dugmić "-"
            korpaArtikalKolicina
            korpaDodaj1Komad                -- ovo je dugmić "+"
            korpaCijenaArtikalUkupno

        --------------------------------
        */

        public FormKupKreiranjeNarudzbe()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemPregledNarudzbi_Click(object sender, EventArgs e)
        {
            Program.frKupPregledNarudzbi.Show();
            this.Hide();
        }

        private void MeniToolStripMenuItemGlavniKupMeni_Click(object sender, EventArgs e)
        {
            Program.frKupGlavna.Show();
            this.Hide();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormKupKreiranjeNarudzbe_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
            NapuniPunuduArtikala();

            string InfoPoruka = "Poštovani kupče, \n\n" +
                                "molimo da obratite pažnju da smo zbog \n" +
                                "jednostavnijeg kreiranja narudžbe omogućili da se \n" +
                                "prebacivanje ubacivanje artikla u korpu \n" +
                                "ili njegovo uklanjanje iz korpe može napraviti:\n\n" +
                                "a) DVOSTRUKIM KLIKOM NA ARTIKAL ili \n\n" +
                                "b) OZNAČAVANJEM ARTIKLA I KORIŠTENJEM DUGMIĆA => <= ";

            if (this.Visible == true)
            {
                MessageBox.Show(InfoPoruka);
            }        
        }

        private void FormKupKreiranjeNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private int VratiRedUKojemJeArtikalUKorpi(int artikalID)
        {
            // Ako artikal postoji u korpi (tj. u dataGridViewKorpa) funkcija indeks reda u kojem je artikal tj. broj od 0 do N-1 (N je broj artikala u korpi)
            // Ako artikal ne postoji u korpi (tj. u dataGridViewKorpa) funkcija vraća -1
            int i = 0;

            while (i < dataGridViewKorpa.Rows.Count
                   &&
                   System.Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells["korpaArtikalID"].Value) != artikalID
                   )
            {
                i = i + 1;
            }

            if (i < dataGridViewKorpa.Rows.Count)
                return i;
            else
                return -1;
        }

        private int VratiRedUKojemJeArtikalUPonudi(int artikalID)
        {
            // Ako artikal postoji u ponudi (tj. u dataGridViewArtikli) funkcija indeks reda u kojem je artikal tj. broj od 0 do N-1 (N je broj artikala u ponudi)
            // Ako artikal ne postoji u ponudi (tj. u dataGridViewArtikli) funkcija vraća -1
            int i = 0;

            while (i < dataGridViewArtikli.Rows.Count
                   &&
                   System.Convert.ToInt32(dataGridViewArtikli.Rows[i].Cells["ponudaArtikalID"].Value) != artikalID
                   )
            {
                i = i + 1;
            }

            if (i < dataGridViewArtikli.Rows.Count)
                return i;
            else
                return -1;
        }

        private void NapuniPunuduArtikala()
        {
            // Metod puni data grid artikala u ponudi (dataGridViewArtikli) sa artiklima čije je stanje na skladištu > 0
            try
            {
                String upit =
                    "select " +
                    "   a.artikal_id as ARTIKAL_ID," +
                    "   concat(a.naziv_artikla, '  [', a.vrsta_artikla, ']') as ARTIKAL_NAZIV_VRSTA," +
                    "   a.cijena as CIJENA," +
                    "   s.kolicina_stanje as KOLICINA_STANJE" +
                    "   from artikli a, skladiste s" +
                    "   where a.artikal_id = s.artikal_id" +
                    "   and s.kolicina_stanje > 0" +
                    "   order by a.artikal_id";

                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(upit, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridViewArtikli.Rows.Clear();

                while (reader.Read())
                {
                    dataGridViewArtikli.Rows.Add(
                        reader["ARTIKAL_ID"],
                        reader["ARTIKAL_NAZIV_VRSTA"],
                        reader["CIJENA"],
                        reader["KOLICINA_STANJE"]
                        );
                }
                con.Close();

                // Obojimo svaki drugi red drugom bojom
                Program.ModificirajGridView(dataGridViewArtikli);
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonDodajUKorpu_Click(object sender, EventArgs e)
        {        
            ubaciKolicinuArtiklaUKorpu(
                System.Convert.ToInt32(textBoxIDArtikla.Text),          // koji artikal ubacijumo
                System.Convert.ToInt32(numericUpDownKolicina.Value)     // u kojoj količini
            );
            errorProvider.Clear();
        }

        private void AzurirajUkupnuCijenuNarudzbe()
        {
            double ukupnaCijena = 0;
            for (int i = 0; i < dataGridViewKorpa.Rows.Count; i++)
            {
                ukupnaCijena = ukupnaCijena +
                    System.Convert.ToDouble(dataGridViewKorpa.Rows[i].Cells["korpaCijenaArtikalUkupno"].Value);
            }
            textBoxUkupnoNarudzba.Text = ukupnaCijena.ToString("N2"); // N2 znači formatiranje na 2 decimale
        }

        private void dataGridViewArtikli_SelectionChanged(object sender, EventArgs e)
        {
            textBoxIDArtikla.Text = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex]
                                    .Cells["ponudaArtikalID"].Value.ToString();
            errorProvider.Clear();
        }

        private void dataGridViewKorpa_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewKorpa.Rows.Count > 0) // potrebno jer bi kod pao ako se ukloni posljednji artikal iz korpe
            {
                textBoxIDArtikla.Text = dataGridViewKorpa.Rows[dataGridViewKorpa.CurrentCell.RowIndex]
                                        .Cells["korpaArtikalID"].Value.ToString();
            }
            errorProvider.Clear();
        }

        private void ubaciKolicinuArtiklaUKorpu(int artikalID, int promjenaKolicine)
        {
            // Metod u korpu dodaje artikal (artikalID) u količini (promjenaKolicine)

            // Najprije provjerimo da li je količina artikla na stanju dovoljna za prebacivanje u korpu
            int redPonuda = VratiRedUKojemJeArtikalUPonudi(artikalID);
            int stanjeNaSkladistu = System.Convert.ToInt32(dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalKolicina"].Value);

            if (stanjeNaSkladistu < promjenaKolicine)
                MessageBox.Show("Tražili ste da u korpu ubacimo " + promjenaKolicine.ToString() + " komada artikla a na skladištu je "
                    + stanjeNaSkladistu + " komada. Smanjite traženu količinu koju želite ubaciti u korpu.");
            else
            {
                // Provjerimo da li je artikal već u korpi i ako jeste treba povećati količinu
                // a ako nije treba ga ubaciti.
                int redKorpa = VratiRedUKojemJeArtikalUKorpi(artikalID);


                double cijenaKomad = System.Convert.ToDouble(dataGridViewArtikli.Rows[redPonuda].Cells["ponudaCijenaArtikalKomad"].Value);

                if (redKorpa == -1)
                {
                    // Artikal nije u korpi pa ga treba ubaciti
                    dataGridViewKorpa.Rows.Add(
                        artikalID,                                                                      // puni kolonu korpaArtikalID
                        dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalNaziv"].Value,          // puni kolonu korpaArtikalNaziv
                        cijenaKomad,                                                                    // puni kolonu korpaCijenaArtikalKomad
                        "-",                                                                            // dugme korpaOduzmi1Komad
                        promjenaKolicine,                                                               // puni kolonu korpaArtikalKolicina
                        "+",                                                                            // dugme korpaDodaj1Komad
                        Math.Round(cijenaKomad * promjenaKolicine, 2)                                   // puni korpaCijenaArtikalUkupno
                    );
                }
                else
                {
                    // Artikal je već u korpi pa treba povećati količinu i ukupnu cijenu artikla u korpi
                    int staraKolicina = System.Convert.ToInt32(dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalKolicina"].Value);
                    dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalKolicina"].Value = staraKolicina + promjenaKolicine;
                    dataGridViewKorpa.Rows[redKorpa].Cells["korpaCijenaArtikalUkupno"].Value = Math.Round(cijenaKomad * (staraKolicina + promjenaKolicine), 2);
                }

                // Oduzimamo količinu artikla iz ponude
                dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalKolicina"].Value =
                    System.Convert.ToInt32(dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalKolicina"].Value) - promjenaKolicine;

                AzurirajUkupnuCijenuNarudzbe();
            }
        }

        private void izbaciKolicinuArtiklaIzKorpe(int artikalID, int promjenaKolicine)
        {

            // Metod iz korpe uklanja artikal (artikalID) u količini (promjenaKolicine)

            if (dataGridViewKorpa.Rows.Count > 0)
            {
                // Najprije provjerimo da li je količina artikla koju želimo vratiti iz korpe (promjenaKolicine) veća od one koja je u korpi
                int redKorpa = VratiRedUKojemJeArtikalUKorpi(artikalID);

                int stanjeUKorpi;
                if (redKorpa == -1)
                    stanjeUKorpi = 0;
                else
                    stanjeUKorpi = System.Convert.ToInt32(dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalKolicina"].Value);

                if (stanjeUKorpi == 0)
                    MessageBox.Show("Odabrani artikal nije u korpi pa ne može biti izbačen iz korpe.");
                else if (stanjeUKorpi < promjenaKolicine)
                    MessageBox.Show("Tražili ste da se iz korpe izbaci " + promjenaKolicine.ToString() + " komada artikla a u korpi je "
                        + stanjeUKorpi + " komada. Smanjite traženu količinu koju želite izbaciti iz korpe.");
                else
                {
                    // Ako se izbacuje tačno ona količina koja je u korpi čitav artikal treba obrisati iz korpe (dataGridViewArtikli)
                    // a ako to nije slučaj onda treba smanjiti količinu artikla u korpi

                    int redPonuda = VratiRedUKojemJeArtikalUPonudi(artikalID);
                    double cijenaKomad = System.Convert.ToDouble(dataGridViewArtikli.Rows[redPonuda].Cells["ponudaCijenaArtikalKomad"].Value);

                    if (stanjeUKorpi == promjenaKolicine)
                    {
                        // Izbacuje se kompletno stanje artikla pa treba obrisati red u dataGridu

                        dataGridViewKorpa.Rows.RemoveAt(redKorpa);
                    }
                    else
                    {
                        // Artikal ostaje i dalje u korpi ali sa smanjenjom količinom
                        int staraKolicina = System.Convert.ToInt32(dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalKolicina"].Value);
                        dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalKolicina"].Value = staraKolicina - promjenaKolicine;
                        dataGridViewKorpa.Rows[redKorpa].Cells["korpaCijenaArtikalUkupno"].Value = Math.Round(cijenaKomad * (staraKolicina - promjenaKolicine), 2);
                    }

                    // Vraćamo količinu artikla u ponudu
                    dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalKolicina"].Value =
                        System.Convert.ToInt32(dataGridViewArtikli.Rows[redPonuda].Cells["ponudaArtikalKolicina"].Value) + promjenaKolicine;

                    AzurirajUkupnuCijenuNarudzbe();
                }
            }        
        }

        private void buttonUkloniIzKorpe_Click(object sender, EventArgs e)
        {
            izbaciKolicinuArtiklaIzKorpe(
                System.Convert.ToInt32(textBoxIDArtikla.Text),          // koji artikal izbacijemo
                System.Convert.ToInt32(numericUpDownKolicina.Value)     // u kojoj količini
            );
            errorProvider.Clear();
        }

        private void dataGridViewKorpa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ovdje se ažuriranje izbacivanje ili dodavanje artikla u korpu u količini od 1 komada
            // kada korisnik klikne na dugme - ili dugme + u data gridu korpe (dataGridViewKorpa)
            
            // Ustanovimo najprije na koju kolonu je korisnik kliknuo
            if (dataGridViewKorpa.CurrentCell.ColumnIndex == 3) 
            {
                // korisnik kliknuo na kolonu 4. tj. dugmić korpaOduzmi1Komad
                int redKorpa = dataGridViewKorpa.CurrentCell.RowIndex;
                int artikalID = System.Convert.ToInt32(dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalID"].Value);
                izbaciKolicinuArtiklaIzKorpe(
                    artikalID,  // koji artikal izbacijemo
                    1           // u kojoj količini
                ); 
            }
            else if (dataGridViewKorpa.CurrentCell.ColumnIndex == 5) 
            {
                // korisnik kliknuo na kolonu 6. tj. dugmić korpaDodaj1Komad
                int redKorpa = dataGridViewKorpa.CurrentCell.RowIndex;
                int artikalID = System.Convert.ToInt32(dataGridViewKorpa.Rows[redKorpa].Cells["korpaArtikalID"].Value);
                ubaciKolicinuArtiklaUKorpu(
                    artikalID,  // koji artikal izbacijemo
                    1           // u kojoj količini
                ); 
            }
        }

        private void buttonKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            if (dataGridViewKorpa.Rows.Count == 0)
                MessageBox.Show("Da biste kreirali narudžbu potrebno je da imate barem jednu stavku u korpi.");
            else
            {
                try
                {

                    // Dohvatamo informaciju o prijavljenom kupcu koju je postavila login forma

                    int kupacID = System.Convert.ToInt32(Program.prijavljeniKupacID);
                    
                    // Za ovog kupca insertujemo zaglavlje narudžbe
                    // Baza će automatski dodijeliti ID narudžbe (jer je to auto inkrement polje)
                    // Baza će također sama upisati vrijeme u kojem je evidentiran insert.

                    Program.insertNarudzbe(kupacID);


                    // Dohvatamo ID kreirane narudžbe koji će nam trebati u narednom koraku za kreiranje stavki ove narudžbe
                    
                    int narudzbaID = Program.vratiPosljednjiIDNarudzbeKupca(kupacID);

                    
                    // Prođimo kroz sve artikle sadržane u gridu dataGridViewKorpa 
                    // i insertujmo za svaki od njih po jedan zapis u stavkama narudžbe
                    // te dodatno umanjimo količinu tog artikla na skladištu
                    
                    for (int i = 0; i < dataGridViewKorpa.Rows.Count; i++)
                    {
                        int artikalID = System.Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells["korpaArtikalID"].Value);
                        int kolicina = System.Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells["korpaArtikalKolicina"].Value);
                        
                        // ubacujemo stavku narudžbe za artikal

                        Program.insertArtiklaUNarudzbu(narudzbaID, artikalID, kolicina);

                        
                        // smanjujemo stanje artikla na skladištu

                        Program.updatePovecajKolicunuArtiklaUSkladistu(artikalID, -kolicina);
                    }

                    MessageBox.Show("Vaša narudžba je uspješno evidentirana u bazi podataka pod brojem " 
                        + narudzbaID + " ! Bićete prebačeni na formu za pregled Vaših narudžbi.");

                    // Brišemo sadržaj korpe
                    dataGridViewKorpa.Rows.Clear();

                    // Otkrivamo formu za pregled narudžbu ali prije toga
                    // na ovoj formi pozivamo njen metod da osvježi grid sa svim narudžbama prijavljenog korisnika
                   
                    Program.frKupPregledNarudzbi.PrikazNarudzbiPrijavljenogKorisnika(false);
                    Program.frKupPregledNarudzbi.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    errorProvider.SetError(buttonKreirajNarudzbu, ex.Message);
                    MessageBox.Show("Dogodila se greška prilikom kreiranja narudžbe! " +
                                    "Za više informacija pređite mišem preko uskličnika!");                
                }
            }
        }

        private void dataGridViewArtikli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Dodaje u korpu artikal na koji smo kliknuli dva puta u listi svih artikala.
            // Dodavanje se vrši u količini kako je rečeno u polju "Količina" (kontrola numericUpDownKolicina).

            if (dataGridViewArtikli.Rows.Count > 0)
            {
                // Nakon dvostrukog klika mišem odabrani artikal će biće selektovan pa možemo koristiti dataGridViewArtikli.CurrentCell.RowIndex
                // da odredimo koji je to artikal

                int artikalID = System.Convert.ToInt32(
                                        dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["ponudaArtikalID"].Value.ToString()
                                      );

                // Sada samo ostaje da ubacimo ovaj artikal u korpu u količini kako je rečeno u kontroli numericUpDownKolicina
                ubaciKolicinuArtiklaUKorpu(
                    artikalID,                                              // koji artikal ubacijumo
                    System.Convert.ToInt32(numericUpDownKolicina.Value)     // u kojoj količini
                );
            }
        }

        private void dataGridViewKorpa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Uklanja artikal na koji smo u korpi kliknuli 2 puta u potpunosti iz korpe
            // ali samo ako u korpi ima nešto i nismo dva puta brzo kliknuli na ćelije u kojima su dugmići "-" i "+" 
            // (da se spriječi da brzo klikanje ba dugmiće "-" i "+" ne obriše artikal iz korpe)

            if (
                    dataGridViewKorpa.Rows.Count > 0                // ima nešto u korpi
                &&  dataGridViewKorpa.CurrentCell.ColumnIndex != 3  // korisnik nije dva puta brzo kliknuo na kolonu 4. tj. dugmić korpaOduzmi1Komad
                &&  dataGridViewKorpa.CurrentCell.ColumnIndex != 5  // korisnik nije dva puta brzo kliknuo na kolonu 6. tj. dugmić korpaDodaj1Komad
                )
            {
                // Nakon dvostrukog klika mišem odabrani artikal će biće selektovan pa možemo koristiti dataGridViewKorpa.CurrentCell.RowIndex
                // da odredimo koji je to artikal i koja je njegova količina u korpi

                int artikalID = System.Convert.ToInt32(
                                        dataGridViewKorpa.Rows[dataGridViewKorpa.CurrentCell.RowIndex].Cells["korpaArtikalID"].Value.ToString()
                                      );

                int kolicinaUKorpi = System.Convert.ToInt32(
                                        dataGridViewKorpa.Rows[dataGridViewKorpa.CurrentCell.RowIndex].Cells["korpaArtikalKolicina"].Value.ToString()
                                      );

                // Sada samo preostaje da uklonimo cjelokupnu količinu artikla iz korpe
                izbaciKolicinuArtiklaIzKorpe(
                    artikalID,                  // koji artikal izbacijemo
                    kolicinaUKorpi              // u kojoj količini
                );
            }
        }

    }
}
