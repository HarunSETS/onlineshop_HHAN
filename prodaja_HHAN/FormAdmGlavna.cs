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
    public partial class FormAdmGlavna : Form
    {
        // varijabla koja odredjuje da li se vidi logo sličica
        bool logoVidljiv = false;
        
        public FormAdmGlavna()
        {
            InitializeComponent();
        }

        private void buttonAdmKupci_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmKupaca.Show();
        }

        private void buttonAdmArtikli_Click(object sender, EventArgs e)
        {
            Program.frAdmArtikli.Show();
            this.Hide();
        }

        private void buttonAdmNarudzbe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmNarudzbi.Show();
        }

        private void ToolStripMenuItemAdmKupaca_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frAdmKupaca.Show();
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

        private void ToolStripMenuItemOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Odjava();
        }

        private void FormAdmGlavna_Load(object sender, EventArgs e)
        {
            labelKorisnikInfo.Text = Program.kupacInfoPrikaz;
        }

        private void FormAdmGlavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void timerZaSliku_Tick(object sender, EventArgs e)
        {
            logoVidljiv = !logoVidljiv;

            pictureBoxLogo.Visible = logoVidljiv;
        }

        private void FormLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                timerZaSliku.Start();
            else
                timerZaSliku.Stop();
        }

    }
}
