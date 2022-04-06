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
    public partial class FormKupKreiranjeNarudzbe : Form
    {
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
        }

        private void FormKupKreiranjeNarudzbe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }        

    }
}
