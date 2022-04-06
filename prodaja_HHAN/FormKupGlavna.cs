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
    public partial class FormKupGlavna : Form
    {
        public FormKupGlavna()
        {
            InitializeComponent();
        }

        private void buttonKreiranjeNarudzbe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupKreiranjeNarudzbe.Show();
        }

        private void buttonPregledNarudzbi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupPregledNarudzbi.Show();
        }

        private void ToolStripMenuItemKreiranjeNarudzbe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupKreiranjeNarudzbe.Show();
        }

        private void ToolStripMenuItemPregledNarudzbi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frKupPregledNarudzbi.Show();
        }

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormKupGlavna_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
        }

        private void FormKupGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
