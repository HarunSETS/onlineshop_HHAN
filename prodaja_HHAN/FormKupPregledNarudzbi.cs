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
    public partial class FormKupPregledNarudzbi : Form
    {
       
        public FormKupPregledNarudzbi()
        {
            InitializeComponent();
            numericUpDownID.Controls.RemoveAt(0); //uklanja strelice sa numericUpDown kompoente za cijenu artikla

        }

        private void ToolStripMenuItemKreiranjeNarudzbe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupKreiranjeNarudzbe.Show();
        }

        private void MeniToolStripMenuItemGlavniKupMeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupGlavna.Show();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormKupPregledNarudzbi_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
            PrikazNarudzbiPrijavljenogKorisnika(false);

            // Smanji širinu kolone ID jer je preširoka i proširi kolone DARTUM i KUPAC u gridu za pregled narudžbi
            dataGridViewNarudzbe.Columns["ID"].Width = 40;
            dataGridViewNarudzbe.Columns["DATUM"].Width = 120;
            dataGridViewNarudzbe.Columns["KUPAC"].Width = 130;
            // Formatiraj ispis prikaz datuma
            dataGridViewNarudzbe.Columns["DATUM"].DefaultCellStyle.Format = "dd.mm.yyyy   hh:mm:ss";

            // Povećaj širinu kolone ARTIKAL u gridu za pregled stavki
            dataGridViewNarudzbeStavke.Columns["ARTIKL"].Width = 195;
            // Podesi desno poravnanje na cijenama i količini i format sa dvije decimale
            dataGridViewNarudzbeStavke.Columns["KOLICINA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNarudzbeStavke.Columns["CIJENA KOMAD [KM]"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNarudzbeStavke.Columns["CIJENA KOMAD [KM]"].DefaultCellStyle.Format = "N2";
            dataGridViewNarudzbeStavke.Columns["UKUPNO [KM]"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNarudzbeStavke.Columns["UKUPNO [KM]"].DefaultCellStyle.Format = "N2";
        }

        private void FormKupPregledNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonKupciTrazi_Click(object sender, EventArgs e)
        {
            // Zbog prikaza poruke ako se narudžba ne nađe, zapamti u pomoćnu varijablu ID narudžbe koji se traži 
            // jer će ga u slučaju da se narudžba ne pronađe počistiti funkcija PrikazNarudzbiPrijavljenogKorisnika.  
            string pomocniIDNarudzbe = numericUpDownID.Text;
            
            PrikazNarudzbiPrijavljenogKorisnika(true);
            PrikazStavkiOdabraneNarudzbe();

            if (dataGridViewNarudzbe.RowCount == 0 && pomocniIDNarudzbe != "")
            {
                MessageBox.Show("Nije pronađena narudžba sa ID = " + pomocniIDNarudzbe + "!");
                // Osvježi ponovo sve narudžbe
                PrikazNarudzbiPrijavljenogKorisnika(true);
                PrikazStavkiOdabraneNarudzbe();
            }
        }

        public void PrikazNarudzbiPrijavljenogKorisnika(bool FiltrirajPoPoljuTrazi)
        {
            // Ako se proslijedi TRUE metod će tražiti samo onu narudžbu prijavljenog kupca čiji je ID zadan u polju "Sistemski ID narudžbe"
            // Ako se proslijedi FALSE metod će tražiti sve narudžbe prijavljenog kupca
            try
            {

                String upit =
                    " select n.narudzbenica_id as ID, n.datum_narudzbe as DATUM, concat(k.ime, ' ', k.prezime) as KUPAC" +
                    " from narudzbenice n, kupci k " +
                    " where n.kupac_id = k.kupac_id " +
                    " and k.kupac_id = " + Program.prijavljeniKupacID;

                // Ako je smo kliknuli na dugmić Traži (tj. ako je FiltrirajPoPoljuTrazi == true) onda se filtrira i po polju "Sistemski ID narudžbe"
                if (FiltrirajPoPoljuTrazi == true && numericUpDownID.Text != "")
                {
                    upit = upit + " and n.narudzbenica_id = " + numericUpDownID.Text;
                }

                upit = upit + " order by n.narudzbenica_id desc";
                
                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(upit, con);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewNarudzbe.DataSource = tabela;
                dataAdapter.Dispose();
                con.Close();

                // mijenjanje izgleda datagridview kontrole
                Program.ModificirajGridView(dataGridViewNarudzbe);

                if (dataGridViewNarudzbe.RowCount == 0)
                {
                    numericUpDownID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrikazStavkiOdabraneNarudzbe()
        {
            string narudzba_id;

            // Ako kontrola koja čuva broj narudžbe (numericUpDownID) nije popunjena naštimaj narudzba_id tako da upit ne vrati niti jednu stavku
            if (numericUpDownID.Text == "")
            { 
                narudzba_id = "null";
            }
            // U protivnom podesi narudzba_id tako da filtira samo stavke narudžbe čiji je ID u kontroli numericUpDownID 
            else
            {
                narudzba_id = numericUpDownID.Text;
            }

            // Pripremi ostatak upita ali pazi da se prikažu samo stavke onih narudžbi koje je unio prijavljeni korisnik
            // jer korisnik u kontroli numericUpDownID može upisati broj narudžbe koju je napravio neki drugi korisnik
            // Zato upit mora da koristi i tabelu narudzbe odnosno i uslov n.kupac_id = Program.prijavljeniKupacID 
            try
            {

                String upit =
                    " select concat(a.naziv_artikla, ' [', a.vrsta_artikla, ']') as ARTIKL," +
                    "        s.kolicina as 'KOLICINA', a.cijena as 'CIJENA KOMAD [KM]', round(a.cijena * s.kolicina, 2) as 'UKUPNO [KM]'" +
                    " from stavke_narudzbenica s, artikli a, narudzbenice n " +
                    " where s.artikal_id = a.artikal_id " +
                    " and s.narudzbenica_id = n.narudzbenica_id" +
                    " and n.kupac_id = " + Program.prijavljeniKupacID +
                    " and s.narudzbenica_id = " + narudzba_id +
                    " order by s.stavka_id asc";

                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(upit, con);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewNarudzbeStavke.DataSource = tabela;
                dataAdapter.Dispose();
                con.Close();

                // Mijenjanje izgleda datagridview kontrole
                Program.ModificirajGridView(dataGridViewNarudzbeStavke);

                // Izračunaj i prikaži ukupnu cijenu narudžbe ako je definisan ID narudžbe
                if (numericUpDownID.Text == "")
                {
                    textBoxTotal.Text = "";
                }
                else
                {
                    textBoxTotal.Text = Program.vratiUkupnuCijenuNarudzbe(System.Convert.ToInt32(numericUpDownID.Text)).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            numericUpDownID.Text = dataGridViewNarudzbe.Rows[dataGridViewNarudzbe.CurrentCell.RowIndex].Cells["ID"].FormattedValue.ToString();
            PrikazStavkiOdabraneNarudzbe();
        }
  
    }
}
