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
    public partial class FormKupPregledNarudzbi : Form
    {
        public FormKupPregledNarudzbi()
        {
            InitializeComponent();
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
        }

        private void FormKupPregledNarudzbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
