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
    public partial class FormAdmKupaca : Form
    {
        public FormAdmKupaca()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemAdmArtikala_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmArtikli.Show();
        }

        private void ToolStripMenuItemPregledBrisanjeNarudzbi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmNarudzbi.Show();
        }

        private void MeniToolStripMenuItemGlavniAdmMeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmGlavna.Show();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormAdmKupaca_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
            IspuniComboBoxoveTipovaKorisnika();
            PrikazKupaca();
            // smanji širinu kolone ID jer je preširoka
            dataGridViewKorisnici.Columns["ID"].Width = 40;
        }

        private void buttonKupciTrazi_Click(object sender, EventArgs e)
        {
            PrikazKupaca();
        }

        private void PrikazKupaca()
        {
            try
            {

                String upit =
                    " select k.kupac_id as ID, k.user as USERNAME, k.pass, k.tip_korisnika_ID, concat(k.tip_korisnika_id, ' - ', t.naziv) as TIP_KORISNIKA," + 
                    "        k.ime as IME, k.prezime as PREZIME, k.grad as GRAD, k.adresa as ADRESA, k.telefon AS TELEFON" +
                    " from kupci k, tipovi_korisnika t " +
                    " where k.tip_korisnika_id = t.tip_korisnika_id";

                if (textBoxImeTrazi.Text != "")
                {
                    upit = upit + " and k.ime like '%" + textBoxImeTrazi.Text.Trim() + "%' ";
                }
                if (textBoxPrezimeTrazi.Text != "")
                {
                    upit = upit + " and k.prezime like '%" + textBoxPrezimeTrazi.Text.Trim() + "%' ";
                }

                upit = upit + " order by k.kupac_id";

                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(upit, con);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewKorisnici.DataSource = tabela;
                dataAdapter.Dispose();
                con.Close();

                // sakrij iz prikaza u datagridview kontroli polja password i tip_korisnika_ID
                dataGridViewKorisnici.Columns["pass"].Visible = false;
                dataGridViewKorisnici.Columns["tip_korisnika_ID"].Visible = false;

                // mijenjanje izgleda datagridview kontrole
                Program.ModificirajGridView(dataGridViewKorisnici);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IspuniComboBoxoveTipovaKorisnika()
        {
            try
            {
                String upit = "select tip_korisnika_id from tipovi_korisnika order by tip_korisnika_id";

                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(upit, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                comboBoxTipKorisnikaAzuriranje.Items.Clear();
                comboBoxTipKorisnikaKreiranje.Items.Clear();
                while (reader.Read())
                {
                    comboBoxTipKorisnikaAzuriranje.Items.Add(reader["tip_korisnika_id"].ToString());
                    comboBoxTipKorisnikaKreiranje.Items.Add(reader["tip_korisnika_id"].ToString());
                }

                con.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonKupciAzuriranje_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Spriječiti ažuriranje korisnika ako nije poznat ID korisnika
            if (textBoxIDAzuriranje.Text == "")
            {
                errorProvider.SetError(dataGridViewKorisnici, "Kliknite na jednog od kupaca u tabeli.");
                MessageBox.Show("Dogodila se greška! Nije odabran kupac kojeg treba ažurirati!");
            }
            // Spriječiti ažuriranje korisnika ako nije poznat password
            else if (maskedTextBoxPass1Azuriranje.Text == "")
            {
                errorProvider.SetError(maskedTextBoxPass1Azuriranje, "Niste postavili šifru!'");
                MessageBox.Show("Dogodila se greška! Niste postavili šifru!");
            }
            // Spriječiti ažuriranje korisnika ako passwordi u oba polja nisu jednaki
            else if (maskedTextBoxPass1Azuriranje.Text != maskedTextBoxPass2Azuriranje.Text)
            {
                errorProvider.SetError(maskedTextBoxPass1Azuriranje, "Vrijednost različite u odnosu na 'Tajna riječ (ponovi)!'");
                MessageBox.Show("Dogodila se greška! Unesene šifre se ne podudaraju!");
            }
            else
                // Inače pokušajmo ažurirati posdatke o korisniku
                try
                {
                    Program.updateKupca(
                            System.Convert.ToInt32(textBoxIDAzuriranje.Text),
                            textBoxUserAzuriranje.Text,
                            maskedTextBoxPass1Azuriranje.Text,
                            comboBoxTipKorisnikaAzuriranje.Text.Trim(),
                            textBoxImeAzuriranje.Text.Trim(),
                            textBoxPrezimeAzuriranje.Text.Trim(),
                            textBoxGradAzuriranje.Text.Trim(),
                            textBoxAdresaAzuriranje.Text.Trim(),
                            textBoxTelefonAzuriranje.Text.Trim()
                        );
                    
                    PrikazKupaca();
                    MessageBox.Show("Podaci o korisniku ažurirani!");
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(pictureBoxKupacAzuriranje, ex.Message);
                    MessageBox.Show("Dogodila se greška! Svi potrebni podaci nisu evidentirani ili nisu uneseni u pravilnom formatu ili se preklapaju sa postojećim! " +
                                    "Za više informacija pređite mišem preko uskličnika!");
                }
        }

        // kad se promjeni selektovani red u dataGridView kontroli popunjavamo podatake na dijelu "Ažuriranje podataka postojećeg korisnika"
        private void dataGridViewKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Iz reda koji je selektiran u gridu prepiši podatke u kontrole u dijelu "Ažuriranje postojećeg korisnika"
            textBoxIDAzuriranje.Text            = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["ID"].FormattedValue.ToString();
            textBoxImeAzuriranje.Text           = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["IME"].FormattedValue.ToString();
            textBoxPrezimeAzuriranje.Text       = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["PREZIME"].FormattedValue.ToString();
            textBoxGradAzuriranje.Text          = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["GRAD"].FormattedValue.ToString();
            textBoxAdresaAzuriranje.Text        = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["ADRESA"].FormattedValue.ToString();
            comboBoxTipKorisnikaAzuriranje.Text = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["tip_korisnika_ID"].FormattedValue.ToString();
            textBoxTelefonAzuriranje.Text       = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["TELEFON"].FormattedValue.ToString();
            textBoxUserAzuriranje.Text          = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["USERNAME"].FormattedValue.ToString();
            maskedTextBoxPass1Azuriranje.Text   = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["pass"].FormattedValue.ToString();
            maskedTextBoxPass2Azuriranje.Text   = maskedTextBoxPass1Azuriranje.Text;

            // Na dijelu "Brisanje korisnika koji nema vezane narudžbe" popuni polje koje čuva ID korisnika koji se briše sa onim koji je selektiran 
            textBoxIDBrisanje.Text              = dataGridViewKorisnici.Rows[dataGridViewKorisnici.CurrentCell.RowIndex].Cells["ID"].FormattedValue.ToString();
        }

        private void buttonKupcKreiranje_Click(object sender, EventArgs e)
        {
            // Spriječiti kreiranje korisnika ako nije poznat password
            if (maskedTextBoxPass1Kreiranje.Text == "")
            {
                errorProvider.SetError(maskedTextBoxPass1Kreiranje, "Niste postavili šifru!'");
                MessageBox.Show("Dogodila se greška! Niste postavili šifru!");
            }
            // Spriječiti kreiranje korisnika ako passwordi u oba polja nisu jednaki
            else if (maskedTextBoxPass1Kreiranje.Text != maskedTextBoxPass2Kreiranje.Text)
            {
                errorProvider.SetError(maskedTextBoxPass1Kreiranje, "Vrijednost različite u odnosu na 'Tajna riječ (ponovi)!'");
                MessageBox.Show("Dogodila se greška! Unesene šifre se ne podudaraju!");
            }
            else
                // Inače pokušajmo kreirati novog korisnika
                try
                {
                    Program.insertKupca(
                            textBoxUserKreiranje.Text.Trim(),
                            maskedTextBoxPass1Kreiranje.Text,
                            comboBoxTipKorisnikaKreiranje.Text,
                            textBoxImeKreiranje.Text.Trim(),
                            textBoxPrezimeKreiranje.Text.Trim(),
                            textBoxGradKreiranje.Text.Trim(),
                            textBoxAdresaKreiranje.Text.Trim(),
                            textBoxTelefonKreiranje.Text.Trim()
                        );

                    PrikazKupaca();
                    MessageBox.Show("Podaci o novom korisniku kreirani!");

                    // Počisti polja u dijelu "Kreiranje novog korisnika"
                    textBoxIDKreiranje.Text             = "";
                    textBoxUserKreiranje.Text           = "";
                    maskedTextBoxPass1Kreiranje.Text    = "";
                    maskedTextBoxPass2Kreiranje.Text    = "";
                    comboBoxTipKorisnikaKreiranje.Text  = "";
                    textBoxImeKreiranje.Text            = "";
                    textBoxPrezimeKreiranje.Text        = "";
                    textBoxGradKreiranje.Text           = "";
                    textBoxAdresaKreiranje.Text         = "";
                    textBoxTelefonKreiranje.Text        = "";
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(pictureBoxKupacKreiranje, ex.Message);
                    MessageBox.Show("Dogodila se greška! Svi potrebni podaci nisu evidentirani ili nisu uneseni u pravilnom formatu ili se preklapaju sa postojećim! " +
                                    "Za više informacija pređite mišem preko uskličnika!");
                }
        }

        private void FormAdmKupaca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBrisanje_Click(object sender, EventArgs e)
        {
            // spriječiti ažuriranje ako nije određen ID kupca
            if (textBoxIDAzuriranje.Text == "")
            {
                errorProvider.SetError(dataGridViewKorisnici, "Kliknite na jednog od korisnika u tabeli.");
                MessageBox.Show("Dogodila se greška! Nije odabran korisnik kojeg treba ažurirati!");
            }
            else if (textBoxIDBrisanje.Text == Program.prijavljeniKupacID)
            {
                MessageBox.Show("Korisnik kojeg želite obrisati ste vi pa to nije dozvoljeno!");
            }
            else
            {
                try
                {
                    Program.brisanjeKupca(System.Convert.ToInt32(textBoxIDBrisanje.Text));
                    PrikazKupaca();
                    MessageBox.Show("Podaci o korisniku ID = " + textBoxIDAzuriranje.Text + " ažurirani!");
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(buttonBrisanje, ex.Message);
                    MessageBox.Show("Nije uspjelo brisanje korisnika jer ima korisnik ima vezane podatke o narudžbama! " +
                        "Za više informacija pređite mišem preko uskličnika!");
                }
            }
        }

        private void textBoxIDBrisanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
