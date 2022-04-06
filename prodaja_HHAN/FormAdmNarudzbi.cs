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
        }

        private void FormAdmNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
