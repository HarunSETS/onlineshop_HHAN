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
    public partial class FormAdmNarudzbi : Form
    {
        public FormAdmNarudzbi()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemAdmArtikala_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmArtikli.Show();
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

        private void ToolStripMenuItemAdmArtikala_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmArtikli.Show();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormAdmNarudzbi_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
            OsvjeziGridNarudzbi();
        }

        private void FormAdmNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OsvjeziGridNarudzbi()
        {
            try
            {
                String upit = " SELECT n.narudzbenica_id as 'Sistemski ID', n.datum_narudzbe as Datum, CONCAT(k.ime, ' ', k.prezime) as 'Ime i prezime kupca'" + 
                              " FROM narudzbenice n, kupci k " +
                              " WHERE n.kupac_id = k.kupac_id " 
                              ;

                /* sadržaj kombo boxa za sortiranje
                    0 Datum narudžbe (od posljednjeg)
                    1 Datum narudžbe (od prvog)
                    2 ID narudžbe (od posljednje)
                    3 ID narudžbe (od prve)
                    4 Ime i prezime kupca (po abecedi)
                    5 Ime i prezime kupca (obrnuto abecedno)
                 */
                
                if (comboBoxSort.SelectedIndex == 0)
                {
                    upit = upit + "ORDER BY n.datum_narudzbe DESC";
                }
                else if (comboBoxSort.SelectedIndex == 1)
                {
                    upit = upit + "ORDER BY n.datum_narudzbe ASC";
                }
                else if (comboBoxSort.SelectedIndex == 2)
                {
                    upit = upit + "ORDER BY n.narudzbenica_id DESC";
                }
                else if (comboBoxSort.SelectedIndex == 3)
                {
                    upit = upit + "ORDER BY n.narudzbenica_id ASC";
                }
                else if (comboBoxSort.SelectedIndex == 4)
                {
                    upit = upit + "ORDER BY CONCAT(k.ime, ' ', k.prezime) ASC";
                }
                else if (comboBoxSort.SelectedIndex == 5)
                {
                    upit = upit + "ORDER BY CONCAT(k.ime, ' ', k.prezime) DESC";
                }
                else
                {
                    upit = upit + "ORDER BY n.narudzbenica_id ASC";
                }


                MySqlConnection con = new MySqlConnection(Program.konekcioniString);
                con.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(upit, con);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dataGridViewNarudzbe.DataSource = tabela;
                dataAdapter.Dispose();
                con.Close();

                dataGridViewNarudzbe.Columns["Sistemski ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewNarudzbe.Columns["Ime i prezime kupca"].Width = 300;
                dataGridViewNarudzbe.Columns["Datum"].Width = 220;
                
                Program.ModificirajGridView(dataGridViewNarudzbe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziGridNarudzbi();
        }

        private void dataGridViewNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();

            textBoxNazivAzuriranje.Text = dataGridViewNarudzbe.Rows[dataGridViewNarudzbe.CurrentCell.RowIndex].Cells["Sistemski ID"].FormattedValue.ToString();

        }

        private void buttonNarudzbeBrisi_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                Program.obrisiNarudzbuINjeneStavke(System.Convert.ToInt32(textBoxNazivAzuriranje.Text));
                OsvjeziGridNarudzbi();
                MessageBox.Show("Uspješno je obrisana narudžba ID = " + textBoxNazivAzuriranje.Text + " !");
            }
            catch (Exception ex)
            {
                errorProvider.SetError(buttonNarudzbeBrisi, ex.Message);
                MessageBox.Show("Dogodila se greška prilikom brisanja narudžbe ID = " + textBoxNazivAzuriranje.Text + " !" +
                    " Za detalje pređite mišem preko uskličnika.");
            }

        }
    
    }
}
