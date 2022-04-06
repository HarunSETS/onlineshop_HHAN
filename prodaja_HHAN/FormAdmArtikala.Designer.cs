namespace prodaja_HHAN
{
    partial class FormAdmArtikala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdmKupaca = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdmArtikala = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPregledBrisanjeNarudzbi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.MeniToolStripMenuItemGlavniAdmMeni = new System.Windows.Forms.ToolStripMenuItem();
            this.labelKorisnikInfo = new System.Windows.Forms.Label();
            this.tabControlArtikli = new System.Windows.Forms.TabControl();
            this.tabPageAzuriranje = new System.Windows.Forms.TabPage();
            this.numericUpDownCijenaAzuriranje = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKolicinaAzuriranje = new System.Windows.Forms.NumericUpDown();
            this.buttonArtikliAzuriranje = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDAzuriranje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKolicinaPrikazAzuriranje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVrstaAzuriranje = new System.Windows.Forms.TextBox();
            this.labelNazivAzuriraj = new System.Windows.Forms.Label();
            this.textBoxNazivAzuriranje = new System.Windows.Forms.TextBox();
            this.tabPageKreiranje = new System.Windows.Forms.TabPage();
            this.numericUpDownCijenaKreiranje = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKolicinaKreiranje = new System.Windows.Forms.NumericUpDown();
            this.buttonArtikliKreiranje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDKreiranje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKolicinaPrikazKreiranje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxVrstaKreiranje = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNazivKreiranje = new System.Windows.Forms.TextBox();
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.buttonArtikliTrazi = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelSifraTrazi = new System.Windows.Forms.Label();
            this.textBoxNazivTrazi = new System.Windows.Forms.TextBox();
            this.textBoxBarKodTrazi = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.tabControlArtikli.SuspendLayout();
            this.tabPageAzuriranje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijenaAzuriranje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicinaAzuriranje)).BeginInit();
            this.tabPageKreiranje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijenaKreiranje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicinaKreiranje)).BeginInit();
            this.groupBoxPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.MeniToolStripMenuItemGlavniAdmMeni});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(662, 24);
            this.menuStrip.TabIndex = 30;
            this.menuStrip.Text = "Glavni meni";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdmKupaca,
            this.ToolStripMenuItemAdmArtikala,
            this.ToolStripMenuItemPregledBrisanjeNarudzbi,
            this.ToolStripMenuItemOdjava});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // ToolStripMenuItemAdmKupaca
            // 
            this.ToolStripMenuItemAdmKupaca.Name = "ToolStripMenuItemAdmKupaca";
            this.ToolStripMenuItemAdmKupaca.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemAdmKupaca.Text = "Administracija korisnika";
            this.ToolStripMenuItemAdmKupaca.Click += new System.EventHandler(this.ToolStripMenuItemAdmKupaca_Click);
            // 
            // ToolStripMenuItemAdmArtikala
            // 
            this.ToolStripMenuItemAdmArtikala.Enabled = false;
            this.ToolStripMenuItemAdmArtikala.Name = "ToolStripMenuItemAdmArtikala";
            this.ToolStripMenuItemAdmArtikala.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemAdmArtikala.Text = "Administracija artikala";
            // 
            // ToolStripMenuItemPregledBrisanjeNarudzbi
            // 
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Name = "ToolStripMenuItemPregledBrisanjeNarudzbi";
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Text = "Pregled i brisanje narudžbi";
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Click += new System.EventHandler(this.ToolStripMenuItemPregledBrisanjeNarudzbi_Click);
            // 
            // ToolStripMenuItemOdjava
            // 
            this.ToolStripMenuItemOdjava.Name = "ToolStripMenuItemOdjava";
            this.ToolStripMenuItemOdjava.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemOdjava.Text = "Odjava iz aplikacije";
            this.ToolStripMenuItemOdjava.Click += new System.EventHandler(this.ToolStripMenuItemOdjava_Click);
            // 
            // MeniToolStripMenuItemGlavniAdmMeni
            // 
            this.MeniToolStripMenuItemGlavniAdmMeni.Name = "MeniToolStripMenuItemGlavniAdmMeni";
            this.MeniToolStripMenuItemGlavniAdmMeni.Size = new System.Drawing.Size(152, 20);
            this.MeniToolStripMenuItemGlavniAdmMeni.Text = "Povratak na glavni ekran";
            this.MeniToolStripMenuItemGlavniAdmMeni.Click += new System.EventHandler(this.MeniToolStripMenuItemGlavniAdmMeni_Click);
            // 
            // labelKorisnikInfo
            // 
            this.labelKorisnikInfo.AutoSize = true;
            this.labelKorisnikInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelKorisnikInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnikInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelKorisnikInfo.Location = new System.Drawing.Point(391, 4);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(134, 14);
            this.labelKorisnikInfo.TabIndex = 31;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // tabControlArtikli
            // 
            this.tabControlArtikli.Controls.Add(this.tabPageAzuriranje);
            this.tabControlArtikli.Controls.Add(this.tabPageKreiranje);
            this.tabControlArtikli.Location = new System.Drawing.Point(12, 221);
            this.tabControlArtikli.Name = "tabControlArtikli";
            this.tabControlArtikli.SelectedIndex = 0;
            this.tabControlArtikli.Size = new System.Drawing.Size(637, 152);
            this.tabControlArtikli.TabIndex = 59;
            // 
            // tabPageAzuriranje
            // 
            this.tabPageAzuriranje.Controls.Add(this.numericUpDownCijenaAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.numericUpDownKolicinaAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.buttonArtikliAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.label8);
            this.tabPageAzuriranje.Controls.Add(this.textBoxIDAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.label7);
            this.tabPageAzuriranje.Controls.Add(this.label3);
            this.tabPageAzuriranje.Controls.Add(this.textBoxKolicinaPrikazAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.label2);
            this.tabPageAzuriranje.Controls.Add(this.label1);
            this.tabPageAzuriranje.Controls.Add(this.textBoxVrstaAzuriranje);
            this.tabPageAzuriranje.Controls.Add(this.labelNazivAzuriraj);
            this.tabPageAzuriranje.Controls.Add(this.textBoxNazivAzuriranje);
            this.tabPageAzuriranje.Location = new System.Drawing.Point(4, 22);
            this.tabPageAzuriranje.Name = "tabPageAzuriranje";
            this.tabPageAzuriranje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAzuriranje.Size = new System.Drawing.Size(629, 126);
            this.tabPageAzuriranje.TabIndex = 0;
            this.tabPageAzuriranje.Text = "Ažuriranje postojećeg artikla";
            this.tabPageAzuriranje.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCijenaAzuriranje
            // 
            this.numericUpDownCijenaAzuriranje.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownCijenaAzuriranje.DecimalPlaces = 2;
            this.numericUpDownCijenaAzuriranje.Location = new System.Drawing.Point(399, 78);
            this.numericUpDownCijenaAzuriranje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCijenaAzuriranje.Name = "numericUpDownCijenaAzuriranje";
            this.numericUpDownCijenaAzuriranje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCijenaAzuriranje.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownCijenaAzuriranje.TabIndex = 153;
            // 
            // numericUpDownKolicinaAzuriranje
            // 
            this.numericUpDownKolicinaAzuriranje.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownKolicinaAzuriranje.Location = new System.Drawing.Point(399, 52);
            this.numericUpDownKolicinaAzuriranje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownKolicinaAzuriranje.Name = "numericUpDownKolicinaAzuriranje";
            this.numericUpDownKolicinaAzuriranje.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownKolicinaAzuriranje.TabIndex = 124;
            // 
            // buttonArtikliAzuriranje
            // 
            this.buttonArtikliAzuriranje.BackColor = System.Drawing.Color.Moccasin;
            this.buttonArtikliAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtikliAzuriranje.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtikliAzuriranje.Location = new System.Drawing.Point(501, 53);
            this.buttonArtikliAzuriranje.Name = "buttonArtikliAzuriranje";
            this.buttonArtikliAzuriranje.Size = new System.Drawing.Size(110, 45);
            this.buttonArtikliAzuriranje.TabIndex = 75;
            this.buttonArtikliAzuriranje.Text = "Ažuriraj podatke o postojećem artiklu";
            this.buttonArtikliAzuriranje.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Sistemski ID artikla";
            // 
            // textBoxIDAzuriranje
            // 
            this.textBoxIDAzuriranje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxIDAzuriranje.Enabled = false;
            this.textBoxIDAzuriranje.Location = new System.Drawing.Point(157, 19);
            this.textBoxIDAzuriranje.Name = "textBoxIDAzuriranje";
            this.textBoxIDAzuriranje.Size = new System.Drawing.Size(61, 20);
            this.textBoxIDAzuriranje.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Dodaj dodatnu količinu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Trenutna količina na skladištu";
            // 
            // textBoxKolicinaPrikazAzuriranje
            // 
            this.textBoxKolicinaPrikazAzuriranje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxKolicinaPrikazAzuriranje.Enabled = false;
            this.textBoxKolicinaPrikazAzuriranje.Location = new System.Drawing.Point(399, 19);
            this.textBoxKolicinaPrikazAzuriranje.Name = "textBoxKolicinaPrikazAzuriranje";
            this.textBoxKolicinaPrikazAzuriranje.Size = new System.Drawing.Size(75, 20);
            this.textBoxKolicinaPrikazAzuriranje.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Cijena (KM)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Vrsta artikla";
            // 
            // textBoxVrstaAzuriranje
            // 
            this.textBoxVrstaAzuriranje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxVrstaAzuriranje.Location = new System.Drawing.Point(86, 75);
            this.textBoxVrstaAzuriranje.Name = "textBoxVrstaAzuriranje";
            this.textBoxVrstaAzuriranje.Size = new System.Drawing.Size(132, 20);
            this.textBoxVrstaAzuriranje.TabIndex = 59;
            // 
            // labelNazivAzuriraj
            // 
            this.labelNazivAzuriraj.AutoSize = true;
            this.labelNazivAzuriraj.Location = new System.Drawing.Point(14, 51);
            this.labelNazivAzuriraj.Name = "labelNazivAzuriraj";
            this.labelNazivAzuriraj.Size = new System.Drawing.Size(65, 13);
            this.labelNazivAzuriraj.TabIndex = 58;
            this.labelNazivAzuriraj.Text = "Naziv artikla";
            // 
            // textBoxNazivAzuriranje
            // 
            this.textBoxNazivAzuriranje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNazivAzuriranje.Location = new System.Drawing.Point(86, 49);
            this.textBoxNazivAzuriranje.Name = "textBoxNazivAzuriranje";
            this.textBoxNazivAzuriranje.Size = new System.Drawing.Size(132, 20);
            this.textBoxNazivAzuriranje.TabIndex = 57;
            // 
            // tabPageKreiranje
            // 
            this.tabPageKreiranje.Controls.Add(this.numericUpDownCijenaKreiranje);
            this.tabPageKreiranje.Controls.Add(this.numericUpDownKolicinaKreiranje);
            this.tabPageKreiranje.Controls.Add(this.buttonArtikliKreiranje);
            this.tabPageKreiranje.Controls.Add(this.label4);
            this.tabPageKreiranje.Controls.Add(this.textBoxIDKreiranje);
            this.tabPageKreiranje.Controls.Add(this.label5);
            this.tabPageKreiranje.Controls.Add(this.label6);
            this.tabPageKreiranje.Controls.Add(this.textBoxKolicinaPrikazKreiranje);
            this.tabPageKreiranje.Controls.Add(this.label9);
            this.tabPageKreiranje.Controls.Add(this.label10);
            this.tabPageKreiranje.Controls.Add(this.textBoxVrstaKreiranje);
            this.tabPageKreiranje.Controls.Add(this.label11);
            this.tabPageKreiranje.Controls.Add(this.textBoxNazivKreiranje);
            this.tabPageKreiranje.Location = new System.Drawing.Point(4, 22);
            this.tabPageKreiranje.Name = "tabPageKreiranje";
            this.tabPageKreiranje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKreiranje.Size = new System.Drawing.Size(629, 126);
            this.tabPageKreiranje.TabIndex = 1;
            this.tabPageKreiranje.Text = "Kreiranje novog artikla";
            this.tabPageKreiranje.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCijenaKreiranje
            // 
            this.numericUpDownCijenaKreiranje.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownCijenaKreiranje.DecimalPlaces = 2;
            this.numericUpDownCijenaKreiranje.Location = new System.Drawing.Point(399, 78);
            this.numericUpDownCijenaKreiranje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCijenaKreiranje.Name = "numericUpDownCijenaKreiranje";
            this.numericUpDownCijenaKreiranje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownCijenaKreiranje.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownCijenaKreiranje.TabIndex = 151;
            // 
            // numericUpDownKolicinaKreiranje
            // 
            this.numericUpDownKolicinaKreiranje.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownKolicinaKreiranje.Location = new System.Drawing.Point(399, 52);
            this.numericUpDownKolicinaKreiranje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownKolicinaKreiranje.Name = "numericUpDownKolicinaKreiranje";
            this.numericUpDownKolicinaKreiranje.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownKolicinaKreiranje.TabIndex = 150;
            // 
            // buttonArtikliKreiranje
            // 
            this.buttonArtikliKreiranje.BackColor = System.Drawing.Color.Moccasin;
            this.buttonArtikliKreiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtikliKreiranje.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtikliKreiranje.Location = new System.Drawing.Point(501, 53);
            this.buttonArtikliKreiranje.Name = "buttonArtikliKreiranje";
            this.buttonArtikliKreiranje.Size = new System.Drawing.Size(110, 45);
            this.buttonArtikliKreiranje.TabIndex = 149;
            this.buttonArtikliKreiranje.Text = "Kreiraj novi artikl";
            this.buttonArtikliKreiranje.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "Sistemski ID artikla";
            // 
            // textBoxIDKreiranje
            // 
            this.textBoxIDKreiranje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxIDKreiranje.Enabled = false;
            this.textBoxIDKreiranje.Location = new System.Drawing.Point(157, 19);
            this.textBoxIDKreiranje.Name = "textBoxIDKreiranje";
            this.textBoxIDKreiranje.Size = new System.Drawing.Size(61, 20);
            this.textBoxIDKreiranje.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Postavi inicijalnu količinu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "Trenutna količina na skladištu";
            // 
            // textBoxKolicinaPrikazKreiranje
            // 
            this.textBoxKolicinaPrikazKreiranje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxKolicinaPrikazKreiranje.Enabled = false;
            this.textBoxKolicinaPrikazKreiranje.Location = new System.Drawing.Point(399, 19);
            this.textBoxKolicinaPrikazKreiranje.Name = "textBoxKolicinaPrikazKreiranje";
            this.textBoxKolicinaPrikazKreiranje.Size = new System.Drawing.Size(75, 20);
            this.textBoxKolicinaPrikazKreiranje.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "Cijena";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 141;
            this.label10.Text = "Vrsta artikla";
            // 
            // textBoxVrstaKreiranje
            // 
            this.textBoxVrstaKreiranje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxVrstaKreiranje.Location = new System.Drawing.Point(86, 75);
            this.textBoxVrstaKreiranje.Name = "textBoxVrstaKreiranje";
            this.textBoxVrstaKreiranje.Size = new System.Drawing.Size(132, 20);
            this.textBoxVrstaKreiranje.TabIndex = 140;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 139;
            this.label11.Text = "Naziv artikla";
            // 
            // textBoxNazivKreiranje
            // 
            this.textBoxNazivKreiranje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNazivKreiranje.Location = new System.Drawing.Point(86, 49);
            this.textBoxNazivKreiranje.Name = "textBoxNazivKreiranje";
            this.textBoxNazivKreiranje.Size = new System.Drawing.Size(132, 20);
            this.textBoxNazivKreiranje.TabIndex = 138;
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.dataGridViewArtikli);
            this.groupBoxPretraga.Controls.Add(this.buttonArtikliTrazi);
            this.groupBoxPretraga.Controls.Add(this.labelNaziv);
            this.groupBoxPretraga.Controls.Add(this.labelSifraTrazi);
            this.groupBoxPretraga.Controls.Add(this.textBoxNazivTrazi);
            this.groupBoxPretraga.Controls.Add(this.textBoxBarKodTrazi);
            this.groupBoxPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPretraga.Location = new System.Drawing.Point(11, 36);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(638, 179);
            this.groupBoxPretraga.TabIndex = 58;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "Pretraga artikala";
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AllowUserToAddRows = false;
            this.dataGridViewArtikli.AllowUserToDeleteRows = false;
            this.dataGridViewArtikli.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(16, 49);
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(600, 115);
            this.dataGridViewArtikli.TabIndex = 41;
            // 
            // buttonArtikliTrazi
            // 
            this.buttonArtikliTrazi.BackColor = System.Drawing.Color.LightCyan;
            this.buttonArtikliTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtikliTrazi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtikliTrazi.Location = new System.Drawing.Point(493, 22);
            this.buttonArtikliTrazi.Name = "buttonArtikliTrazi";
            this.buttonArtikliTrazi.Size = new System.Drawing.Size(123, 21);
            this.buttonArtikliTrazi.TabIndex = 40;
            this.buttonArtikliTrazi.Text = "Traži ...";
            this.buttonArtikliTrazi.UseVisualStyleBackColor = false;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(288, 25);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 39;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelSifraTrazi
            // 
            this.labelSifraTrazi.AutoSize = true;
            this.labelSifraTrazi.Location = new System.Drawing.Point(13, 25);
            this.labelSifraTrazi.Name = "labelSifraTrazi";
            this.labelSifraTrazi.Size = new System.Drawing.Size(73, 13);
            this.labelSifraTrazi.TabIndex = 38;
            this.labelSifraTrazi.Text = "Šifra (bar kod)";
            // 
            // textBoxNazivTrazi
            // 
            this.textBoxNazivTrazi.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNazivTrazi.Location = new System.Drawing.Point(339, 22);
            this.textBoxNazivTrazi.Name = "textBoxNazivTrazi";
            this.textBoxNazivTrazi.Size = new System.Drawing.Size(120, 20);
            this.textBoxNazivTrazi.TabIndex = 37;
            // 
            // textBoxBarKodTrazi
            // 
            this.textBoxBarKodTrazi.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxBarKodTrazi.Location = new System.Drawing.Point(91, 22);
            this.textBoxBarKodTrazi.Name = "textBoxBarKodTrazi";
            this.textBoxBarKodTrazi.Size = new System.Drawing.Size(120, 20);
            this.textBoxBarKodTrazi.TabIndex = 36;
            // 
            // FormAdmArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 396);
            this.Controls.Add(this.tabControlArtikli);
            this.Controls.Add(this.groupBoxPretraga);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormAdmArtikala";
            this.Text = "ADMINISTRATOR - Administracija artikala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmArtikala_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmArtikala_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlArtikli.ResumeLayout(false);
            this.tabPageAzuriranje.ResumeLayout(false);
            this.tabPageAzuriranje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijenaAzuriranje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicinaAzuriranje)).EndInit();
            this.tabPageKreiranje.ResumeLayout(false);
            this.tabPageKreiranje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijenaKreiranje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicinaKreiranje)).EndInit();
            this.groupBoxPretraga.ResumeLayout(false);
            this.groupBoxPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdmKupaca;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdmArtikala;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPregledBrisanjeNarudzbi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOdjava;
        private System.Windows.Forms.ToolStripMenuItem MeniToolStripMenuItemGlavniAdmMeni;
        private System.Windows.Forms.Label labelKorisnikInfo;
        private System.Windows.Forms.TabControl tabControlArtikli;
        private System.Windows.Forms.TabPage tabPageAzuriranje;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicinaAzuriranje;
        private System.Windows.Forms.Button buttonArtikliAzuriranje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIDAzuriranje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKolicinaPrikazAzuriranje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVrstaAzuriranje;
        private System.Windows.Forms.Label labelNazivAzuriraj;
        private System.Windows.Forms.TextBox textBoxNazivAzuriranje;
        private System.Windows.Forms.TabPage tabPageKreiranje;
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.Button buttonArtikliTrazi;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelSifraTrazi;
        private System.Windows.Forms.TextBox textBoxNazivTrazi;
        private System.Windows.Forms.TextBox textBoxBarKodTrazi;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicinaKreiranje;
        private System.Windows.Forms.Button buttonArtikliKreiranje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDKreiranje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKolicinaPrikazKreiranje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxVrstaKreiranje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNazivKreiranje;
        private System.Windows.Forms.NumericUpDown numericUpDownCijenaKreiranje;
        private System.Windows.Forms.NumericUpDown numericUpDownCijenaAzuriranje;
    }
}