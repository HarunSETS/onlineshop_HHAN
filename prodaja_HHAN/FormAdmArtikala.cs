using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

        private void FormAdmArtikala_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
