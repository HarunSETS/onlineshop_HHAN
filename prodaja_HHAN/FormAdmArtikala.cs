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
    public partial class FormAdmArtikala : Form
    {
        public FormAdmArtikala()
        {
            InitializeComponent();
            numericUpDownCijenaAzuriranje.Controls.RemoveAt(0); //uklanja strelice sa numericUoDown kompoente za cijenu artikla
            numericUpDownCijenaKreiranje.Controls.RemoveAt(0); //uklanja strelice sa numericUoDown kompoente za cijenu artikla
        }

        private void MeniToolStripMenuItemGlavniAdmMeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmGlavna.Show();
        }

        private void ToolStripMenuItemAdmKupaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmKupaca.Show();
        }

        private void ToolStripMenuItemPregledBrisanjeNarudzbi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmNarudzbi.Show();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormAdmArtikala_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
            PrikazArtikla();
            
            // smanji širinu kolone ID jer je preširoka
            dataGridViewArtikli.Columns["ID"].Width             = 40;
            // povećati širnu drugih kolona
            dataGridViewArtikli.Columns["BAR KOD"].Width        = 100;
            dataGridViewArtikli.Columns["NAZIV"].Width          = 200;
            dataGridViewArtikli.Columns["VRSTA"].Width          = 130;
            dataGridViewArtikli.Columns["CIJENA [KM]"].Width    = 120;
        }

        private void FormAdmArtikala_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PrikazArtikla()
        {
            try
            {

                String upit =
                    " select a.artikal_id as ID, a.bar_kod as 'BAR KOD', a.naziv_artikla as NAZIV," +
                    "        a.vrsta_artikla as VRSTA, a.cijena as 'CIJENA [KM]'" +
                    " from artikli a " +
                    " where 1=1 "; // dodato 1=1 kako bi se lakše spojili nastavci za filter po bar kodu i nazivu

                if (textBoxBarKodTrazi.Text != "")
                {
                    upit = upit + " and a.bar_kod like '%" + textBoxBarKodTrazi.Text.Trim() + "%' ";
                }
                if (textBoxNazivTrazi.Text != "")
                {
                    upit = upit + " and a.naziv_artikla like '%" + textBoxNazivTrazi.Text.Trim() + "%' ";
                }

                upit = upit + " order by a.artikal_id";

                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(upit, con);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewArtikli.DataSource = tabela;
                dataAdapter.Dispose();
                con.Close();

                // mijenjanje izgleda datagridview kontrole
                Program.ModificirajGridView(dataGridViewArtikli);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonArtikliTrazi_Click(object sender, EventArgs e)
        {
            PrikazArtikla();
        }

        private void buttonArtikliAzuriranje_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            try
            {
                // Spriječiti ažuriranje ako nije određen ID artikla
                if (textBoxIDAzuriranje.Text == "")
                {
                    errorProvider.SetError(dataGridViewArtikli, "Kliknite na jedan od artikala u tabeli.");
                    MessageBox.Show("Dogodila se greška! Nije odabran artikal kojeg treba ažurirati!");
                }
                // Spriječiti ažuriranje ako bi novo stanje na skladištu bilo manje od 0
                else if (Program.vratiKolicinuArtiklaNaSkladistu(System.Convert.ToInt32(textBoxIDAzuriranje.Text))
                    + System.Convert.ToInt32(numericUpDownKolicinaAzuriranje.Text) < 0)
                {
                    errorProvider.SetError(numericUpDownKolicinaAzuriranje, "Uskladite količinu na skladištu koju želite oduzeti sa trenutnom količinom na skladištu.");
                    MessageBox.Show("Ažuriranje nije moguće jer bi nova količina na skladištu bila negativna!");
                }
                // Spriječiti ažuriranje ako cijena nije određena ili je manja od 0
                else if (numericUpDownCijenaAzuriranje.Text == "" || System.Convert.ToDouble(numericUpDownCijenaAzuriranje.Text) < 0)
                {
                    errorProvider.SetError(numericUpDownCijenaAzuriranje, "Cijena artikla mora biti 0 KM ili više od 0 KM.");
                    MessageBox.Show("Ažuriranje nije moguće jer nije određena ili nije odgovarajuća cijena artikla (minimalna cijena je 0 KM)!");
                }
                else
                {
                    // Ažuriranje podataka o artiklu
                    Program.updateArtikla(
                            System.Convert.ToInt32(textBoxIDAzuriranje.Text),
                            textBoxBarKodAzuriranje.Text.Trim(),
                            textBoxNazivAzuriranje.Text.Trim(),
                            textBoxVrstaAzuriranje.Text.Trim(),
                            System.Convert.ToDouble(numericUpDownCijenaAzuriranje.Text)
                        );

                    // Ažuriranje podataka o količini artikla na skladištu ako je ista zadana
                    if (numericUpDownKolicinaAzuriranje.Text != "")
                    {
                        Program.updatePovecajKolicunuArtiklaUSkladistu(System.Convert.ToInt32(textBoxIDAzuriranje.Text), System.Convert.ToInt32(numericUpDownKolicinaAzuriranje.Text));
                    }

                    MessageBox.Show("Podaci o artiklu ID = " + textBoxIDAzuriranje.Text + " ažurirani!");

                    // Osvježavanje informacija
                    PrikazArtikla();
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(buttonArtikliAzuriranje, ex.Message);
                MessageBox.Show("Dogodila se greška! Svi potrebni podaci nisu evidentirani ili nisu uneseni u pravilnom formatu ili se preklapaju sa postojećim! " +
                                "Za više informacija pređite mišem preko uskličnika!");
            }
        }

        private void buttonArtikliKreiranje_Click(object sender, EventArgs e)
        {
            try
            {
                // Spriječiti kreiranje artikla ako nije poznata količina artikla na skladištu
                if (numericUpDownKolicinaKreiranje.Text == "" ||System.Convert.ToInt32(numericUpDownKolicinaKreiranje.Text) < 0)
                {
                    errorProvider.SetError(numericUpDownKolicinaKreiranje, "Definirajte inicijalno stanje količine artikla na skladištu.");
                    MessageBox.Show("Kreiranje artikla nije moguće jer nije određeno inicijalno stanje na skladištu (mora biti 0 ili više od 0)!");
                }
                // Spriječiti kreiranje artikla ako cijena nije određena ili je manja od 0
                else if (numericUpDownCijenaKreiranje.Text == "" || System.Convert.ToDouble(numericUpDownCijenaKreiranje.Text) < 0)
                {
                    errorProvider.SetError(numericUpDownCijenaKreiranje, "Cijena artikla mora biti 0 KM ili više od 0 KM.");
                    MessageBox.Show("Ažuriranje nije moguće jer nije određena ili nije odgovarajuća cijena artikla (minimalna cijena je 0 KM)!");
                }
                else
                {
                    // Kreriranje novog artikla
                    Program.insertArtikla(
                            textBoxBarKodKreiranje.Text.Trim(),
                            textBoxNazivKreiranje.Text.Trim(),
                            textBoxVrstaKreiranje.Text.Trim(),
                            System.Convert.ToDouble(numericUpDownCijenaKreiranje.Text)
                        );

                    // Kreriranje zapisa o stanju artikla na skladištu
                        
                    // Najprije dohvatamo ID artikla koji smo upravo kreirali (to se radi na osnovu njegovog bar koda 
                    // jer je bar kod unique polje u bazi pa u bazi može postojati samo jedan artikl sa određenim bar kodom.

                    int artiklId = Program.vratiIDArtiklaNaOsnovuBarKoda(textBoxBarKodKreiranje.Text);

                    // Sada ubacujemo zapis u skladište o stanju artikla
                    Program.insertPostaviInicijalnoStanjeArtiklaNaSkladistu(artiklId, System.Convert.ToInt32(numericUpDownKolicinaKreiranje.Text));

                    MessageBox.Show("Podaci o novom artiklu kreirani!");

                    // Osvježavanje informacija
                    PrikazArtikla();

                    // Počisti polja u dijelu "Kreiranje novog artikla"
                    textBoxIDKreiranje.Text                 = "";
                    textBoxBarKodKreiranje.Text             = "";
                    textBoxNazivKreiranje.Text              = "";
                    textBoxVrstaKreiranje.Text              = "";
                    textBoxKolicinaPrikazKreiranje.Text     = "";
                    numericUpDownKolicinaKreiranje.Text     = "";
                    numericUpDownCijenaKreiranje.Text       = "";

                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(buttonArtikliKreiranje, ex.Message);
                MessageBox.Show("Dogodila se greška! Svi potrebni podaci nisu evidentirani ili nisu uneseni u pravilnom formatu ili se preklapaju sa postojećim! " +
                    "Za više informacija pređite mišem preko uskličnika!");
            }
        }

        private void dataGridViewArtikli_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            
            // Iz reda koji je selektiran u gridu prepiši podatke u kontrole u dijelu "Ažuriranje postojećeg artikla"

            textBoxIDAzuriranje.Text                = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["ID"].FormattedValue.ToString();
            textBoxBarKodAzuriranje.Text            = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["BAR KOD"].FormattedValue.ToString();
            textBoxNazivAzuriranje.Text             = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["NAZIV"].FormattedValue.ToString();
            textBoxVrstaAzuriranje.Text             = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["VRSTA"].FormattedValue.ToString();
            numericUpDownCijenaAzuriranje.Text      = dataGridViewArtikli.Rows[dataGridViewArtikli.CurrentCell.RowIndex].Cells["CIJENA [KM]"].FormattedValue.ToString();

            // Postavi količinu koja se dodaje u skladište na 0
            numericUpDownKolicinaAzuriranje.Text    = "0";

            // Dohvati iz baze trenutnu količinu na skladištu i to prikaži u odgovarajućem polju u dijelu "Ažuriranje postojećeg artikla"
            textBoxKolicinaPrikazAzuriranje.Text    = Program.vratiKolicinuArtiklaNaSkladistu(System.Convert.ToInt32(textBoxIDAzuriranje.Text)).ToString();
        }

    }
}
