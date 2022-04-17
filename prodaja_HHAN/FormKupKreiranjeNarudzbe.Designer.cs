namespace prodaja_HHAN
{
    partial class FormKupKreiranjeNarudzbe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKreiranjeNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPregledNarudzbi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.MeniToolStripMenuItemGlavniKupMeni = new System.Windows.Forms.ToolStripMenuItem();
            this.labelKorisnikInfo = new System.Windows.Forms.Label();
            this.groupBoxArtikli = new System.Windows.Forms.GroupBox();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.ponudaArtikalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponudaArtikalNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponudaCijenaArtikalKomad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponudaArtikalKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxKorpa = new System.Windows.Forms.GroupBox();
            this.buttonKreirajNarudzbu = new System.Windows.Forms.Button();
            this.textBoxUkupnoNarudzba = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKorpa = new System.Windows.Forms.DataGridView();
            this.korpaArtikalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korpaArtikalNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korpaCijenaArtikalKomad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korpaOduzmi1Komad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.korpaArtikalKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korpaDodaj1Komad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.korpaCijenaArtikalUkupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajUKorpu = new System.Windows.Forms.Button();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.buttonUkloniIzKorpe = new System.Windows.Forms.Button();
            this.textBoxIDArtikla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBoxArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.groupBoxKorpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.MeniToolStripMenuItemGlavniKupMeni});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "Glavni meni";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemKreiranjeNarudzbe,
            this.ToolStripMenuItemPregledNarudzbi,
            this.ToolStripMenuItemOdjava});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // ToolStripMenuItemKreiranjeNarudzbe
            // 
            this.ToolStripMenuItemKreiranjeNarudzbe.Enabled = false;
            this.ToolStripMenuItemKreiranjeNarudzbe.Name = "ToolStripMenuItemKreiranjeNarudzbe";
            this.ToolStripMenuItemKreiranjeNarudzbe.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemKreiranjeNarudzbe.Text = "Kreiranje narudžbi";
            // 
            // ToolStripMenuItemPregledNarudzbi
            // 
            this.ToolStripMenuItemPregledNarudzbi.Name = "ToolStripMenuItemPregledNarudzbi";
            this.ToolStripMenuItemPregledNarudzbi.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemPregledNarudzbi.Text = "Pregled narudžbi";
            this.ToolStripMenuItemPregledNarudzbi.Click += new System.EventHandler(this.ToolStripMenuItemPregledNarudzbi_Click);
            // 
            // ToolStripMenuItemOdjava
            // 
            this.ToolStripMenuItemOdjava.Name = "ToolStripMenuItemOdjava";
            this.ToolStripMenuItemOdjava.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemOdjava.Text = "Odjava iz aplikacije";
            this.ToolStripMenuItemOdjava.Click += new System.EventHandler(this.ToolStripMenuItemOdjava_Click);
            // 
            // MeniToolStripMenuItemGlavniKupMeni
            // 
            this.MeniToolStripMenuItemGlavniKupMeni.Name = "MeniToolStripMenuItemGlavniKupMeni";
            this.MeniToolStripMenuItemGlavniKupMeni.Size = new System.Drawing.Size(152, 20);
            this.MeniToolStripMenuItemGlavniKupMeni.Text = "Povratak na glavni ekran";
            this.MeniToolStripMenuItemGlavniKupMeni.Click += new System.EventHandler(this.MeniToolStripMenuItemGlavniKupMeni_Click);
            // 
            // labelKorisnikInfo
            // 
            this.labelKorisnikInfo.AutoSize = true;
            this.labelKorisnikInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelKorisnikInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnikInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelKorisnikInfo.Location = new System.Drawing.Point(855, 5);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(134, 14);
            this.labelKorisnikInfo.TabIndex = 34;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // groupBoxArtikli
            // 
            this.groupBoxArtikli.Controls.Add(this.dataGridViewArtikli);
            this.groupBoxArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxArtikli.Location = new System.Drawing.Point(12, 38);
            this.groupBoxArtikli.Name = "groupBoxArtikli";
            this.groupBoxArtikli.Size = new System.Drawing.Size(433, 309);
            this.groupBoxArtikli.TabIndex = 40;
            this.groupBoxArtikli.TabStop = false;
            this.groupBoxArtikli.Text = "Raspoloživi artikli";
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AllowUserToAddRows = false;
            this.dataGridViewArtikli.AllowUserToDeleteRows = false;
            this.dataGridViewArtikli.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ponudaArtikalID,
            this.ponudaArtikalNaziv,
            this.ponudaCijenaArtikalKomad,
            this.ponudaArtikalKolicina});
            this.dataGridViewArtikli.Location = new System.Drawing.Point(9, 33);
            this.dataGridViewArtikli.MultiSelect = false;
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            this.dataGridViewArtikli.RowHeadersVisible = false;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(409, 258);
            this.dataGridViewArtikli.TabIndex = 131;
            this.dataGridViewArtikli.SelectionChanged += new System.EventHandler(this.dataGridViewArtikli_SelectionChanged);
            this.dataGridViewArtikli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewArtikli_MouseDoubleClick);
            // 
            // ponudaArtikalID
            // 
            this.ponudaArtikalID.Frozen = true;
            this.ponudaArtikalID.HeaderText = "ID artikla";
            this.ponudaArtikalID.Name = "ponudaArtikalID";
            this.ponudaArtikalID.ReadOnly = true;
            this.ponudaArtikalID.Width = 40;
            // 
            // ponudaArtikalNaziv
            // 
            this.ponudaArtikalNaziv.Frozen = true;
            this.ponudaArtikalNaziv.HeaderText = "Naziv [vrsta] artikla";
            this.ponudaArtikalNaziv.Name = "ponudaArtikalNaziv";
            this.ponudaArtikalNaziv.ReadOnly = true;
            this.ponudaArtikalNaziv.Width = 195;
            // 
            // ponudaCijenaArtikalKomad
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.ponudaCijenaArtikalKomad.DefaultCellStyle = dataGridViewCellStyle8;
            this.ponudaCijenaArtikalKomad.HeaderText = "Cijena komad [KM]";
            this.ponudaCijenaArtikalKomad.Name = "ponudaCijenaArtikalKomad";
            this.ponudaCijenaArtikalKomad.ReadOnly = true;
            this.ponudaCijenaArtikalKomad.Width = 60;
            // 
            // ponudaArtikalKolicina
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ponudaArtikalKolicina.DefaultCellStyle = dataGridViewCellStyle9;
            this.ponudaArtikalKolicina.HeaderText = "Količina skladište";
            this.ponudaArtikalKolicina.Name = "ponudaArtikalKolicina";
            this.ponudaArtikalKolicina.ReadOnly = true;
            this.ponudaArtikalKolicina.Width = 90;
            // 
            // groupBoxKorpa
            // 
            this.groupBoxKorpa.Controls.Add(this.buttonKreirajNarudzbu);
            this.groupBoxKorpa.Controls.Add(this.textBoxUkupnoNarudzba);
            this.groupBoxKorpa.Controls.Add(this.label4);
            this.groupBoxKorpa.Controls.Add(this.dataGridViewKorpa);
            this.groupBoxKorpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxKorpa.Location = new System.Drawing.Point(665, 45);
            this.groupBoxKorpa.Name = "groupBoxKorpa";
            this.groupBoxKorpa.Size = new System.Drawing.Size(532, 302);
            this.groupBoxKorpa.TabIndex = 41;
            this.groupBoxKorpa.TabStop = false;
            this.groupBoxKorpa.Text = "Korpa";
            // 
            // buttonKreirajNarudzbu
            // 
            this.buttonKreirajNarudzbu.BackColor = System.Drawing.Color.Moccasin;
            this.buttonKreirajNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKreirajNarudzbu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreirajNarudzbu.Location = new System.Drawing.Point(15, 253);
            this.buttonKreirajNarudzbu.Name = "buttonKreirajNarudzbu";
            this.buttonKreirajNarudzbu.Size = new System.Drawing.Size(228, 31);
            this.buttonKreirajNarudzbu.TabIndex = 130;
            this.buttonKreirajNarudzbu.Text = "KREIRAJ NARUDŽBU";
            this.buttonKreirajNarudzbu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKreirajNarudzbu.UseVisualStyleBackColor = false;
            this.buttonKreirajNarudzbu.Click += new System.EventHandler(this.buttonKreirajNarudzbu_Click);
            // 
            // textBoxUkupnoNarudzba
            // 
            this.textBoxUkupnoNarudzba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxUkupnoNarudzba.Enabled = false;
            this.textBoxUkupnoNarudzba.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUkupnoNarudzba.Location = new System.Drawing.Point(422, 252);
            this.textBoxUkupnoNarudzba.Name = "textBoxUkupnoNarudzba";
            this.textBoxUkupnoNarudzba.Size = new System.Drawing.Size(93, 27);
            this.textBoxUkupnoNarudzba.TabIndex = 74;
            this.textBoxUkupnoNarudzba.Text = "0.00";
            this.textBoxUkupnoNarudzba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ukupno za platiti (KM)";
            // 
            // dataGridViewKorpa
            // 
            this.dataGridViewKorpa.AllowUserToAddRows = false;
            this.dataGridViewKorpa.AllowUserToDeleteRows = false;
            this.dataGridViewKorpa.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewKorpa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korpaArtikalID,
            this.korpaArtikalNaziv,
            this.korpaCijenaArtikalKomad,
            this.korpaOduzmi1Komad,
            this.korpaArtikalKolicina,
            this.korpaDodaj1Komad,
            this.korpaCijenaArtikalUkupno});
            this.dataGridViewKorpa.Location = new System.Drawing.Point(15, 26);
            this.dataGridViewKorpa.MultiSelect = false;
            this.dataGridViewKorpa.Name = "dataGridViewKorpa";
            this.dataGridViewKorpa.ReadOnly = true;
            this.dataGridViewKorpa.RowHeadersVisible = false;
            this.dataGridViewKorpa.Size = new System.Drawing.Size(501, 212);
            this.dataGridViewKorpa.TabIndex = 42;
            this.dataGridViewKorpa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorpa_CellClick);
            this.dataGridViewKorpa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorpa_CellDoubleClick);
            this.dataGridViewKorpa.SelectionChanged += new System.EventHandler(this.dataGridViewKorpa_SelectionChanged);
            // 
            // korpaArtikalID
            // 
            this.korpaArtikalID.Frozen = true;
            this.korpaArtikalID.HeaderText = "ID artikla";
            this.korpaArtikalID.Name = "korpaArtikalID";
            this.korpaArtikalID.ReadOnly = true;
            this.korpaArtikalID.Width = 40;
            // 
            // korpaArtikalNaziv
            // 
            this.korpaArtikalNaziv.Frozen = true;
            this.korpaArtikalNaziv.HeaderText = "Naziv [vrsta] artikla";
            this.korpaArtikalNaziv.Name = "korpaArtikalNaziv";
            this.korpaArtikalNaziv.ReadOnly = true;
            this.korpaArtikalNaziv.Width = 195;
            // 
            // korpaCijenaArtikalKomad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.korpaCijenaArtikalKomad.DefaultCellStyle = dataGridViewCellStyle10;
            this.korpaCijenaArtikalKomad.HeaderText = "Cijena komad [KM]";
            this.korpaCijenaArtikalKomad.Name = "korpaCijenaArtikalKomad";
            this.korpaCijenaArtikalKomad.ReadOnly = true;
            this.korpaCijenaArtikalKomad.Width = 60;
            // 
            // korpaOduzmi1Komad
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.NullValue = "-";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.korpaOduzmi1Komad.DefaultCellStyle = dataGridViewCellStyle11;
            this.korpaOduzmi1Komad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.korpaOduzmi1Komad.HeaderText = "-";
            this.korpaOduzmi1Komad.Name = "korpaOduzmi1Komad";
            this.korpaOduzmi1Komad.ReadOnly = true;
            this.korpaOduzmi1Komad.Text = "";
            this.korpaOduzmi1Komad.ToolTipText = "smanji količinu za 1";
            this.korpaOduzmi1Komad.Width = 30;
            // 
            // korpaArtikalKolicina
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.korpaArtikalKolicina.DefaultCellStyle = dataGridViewCellStyle12;
            this.korpaArtikalKolicina.HeaderText = "Količina";
            this.korpaArtikalKolicina.Name = "korpaArtikalKolicina";
            this.korpaArtikalKolicina.ReadOnly = true;
            this.korpaArtikalKolicina.Width = 60;
            // 
            // korpaDodaj1Komad
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.NullValue = "+";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Lime;
            this.korpaDodaj1Komad.DefaultCellStyle = dataGridViewCellStyle13;
            this.korpaDodaj1Komad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.korpaDodaj1Komad.HeaderText = "+";
            this.korpaDodaj1Komad.Name = "korpaDodaj1Komad";
            this.korpaDodaj1Komad.ReadOnly = true;
            this.korpaDodaj1Komad.Text = "";
            this.korpaDodaj1Komad.ToolTipText = "povećaj količinu za 1";
            this.korpaDodaj1Komad.Width = 30;
            // 
            // korpaCijenaArtikalUkupno
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "-";
            this.korpaCijenaArtikalUkupno.DefaultCellStyle = dataGridViewCellStyle14;
            this.korpaCijenaArtikalUkupno.HeaderText = "Cijena ukupno [KM]";
            this.korpaCijenaArtikalUkupno.Name = "korpaCijenaArtikalUkupno";
            this.korpaCijenaArtikalUkupno.ReadOnly = true;
            this.korpaCijenaArtikalUkupno.Width = 80;
            // 
            // buttonDodajUKorpu
            // 
            this.buttonDodajUKorpu.BackColor = System.Drawing.Color.Moccasin;
            this.buttonDodajUKorpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajUKorpu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajUKorpu.Location = new System.Drawing.Point(460, 84);
            this.buttonDodajUKorpu.Name = "buttonDodajUKorpu";
            this.buttonDodajUKorpu.Size = new System.Drawing.Size(190, 38);
            this.buttonDodajUKorpu.TabIndex = 42;
            this.buttonDodajUKorpu.Text = "=>  Dodaj artikl u korpu   =>";
            this.buttonDodajUKorpu.UseVisualStyleBackColor = false;
            this.buttonDodajUKorpu.Click += new System.EventHandler(this.buttonDodajUKorpu_Click);
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownKolicina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownKolicina.Location = new System.Drawing.Point(561, 160);
            this.numericUpDownKolicina.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownKolicina.TabIndex = 125;
            this.numericUpDownKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonUkloniIzKorpe
            // 
            this.buttonUkloniIzKorpe.BackColor = System.Drawing.Color.Moccasin;
            this.buttonUkloniIzKorpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUkloniIzKorpe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUkloniIzKorpe.Location = new System.Drawing.Point(460, 211);
            this.buttonUkloniIzKorpe.Name = "buttonUkloniIzKorpe";
            this.buttonUkloniIzKorpe.Size = new System.Drawing.Size(190, 38);
            this.buttonUkloniIzKorpe.TabIndex = 126;
            this.buttonUkloniIzKorpe.Text = "<=  Ukloni artikl iz korpe   <=";
            this.buttonUkloniIzKorpe.UseVisualStyleBackColor = false;
            this.buttonUkloniIzKorpe.Click += new System.EventHandler(this.buttonUkloniIzKorpe_Click);
            // 
            // textBoxIDArtikla
            // 
            this.textBoxIDArtikla.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxIDArtikla.Enabled = false;
            this.textBoxIDArtikla.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDArtikla.Location = new System.Drawing.Point(460, 160);
            this.textBoxIDArtikla.Name = "textBoxIDArtikla";
            this.textBoxIDArtikla.Size = new System.Drawing.Size(86, 27);
            this.textBoxIDArtikla.TabIndex = 127;
            this.textBoxIDArtikla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "ID odabranog artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Količina";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormKupKreiranjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDArtikla);
            this.Controls.Add(this.buttonUkloniIzKorpe);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.buttonDodajUKorpu);
            this.Controls.Add(this.groupBoxKorpa);
            this.Controls.Add(this.groupBoxArtikli);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormKupKreiranjeNarudzbe";
            this.Text = "Kreiranje narudžbe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKupKreiranjeNarudzbe_FormClosed);
            this.Load += new System.EventHandler(this.FormKupKreiranjeNarudzbe_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxArtikli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.groupBoxKorpa.ResumeLayout(false);
            this.groupBoxKorpa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKreiranjeNarudzbe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPregledNarudzbi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOdjava;
        private System.Windows.Forms.ToolStripMenuItem MeniToolStripMenuItemGlavniKupMeni;
        private System.Windows.Forms.Label labelKorisnikInfo;
        private System.Windows.Forms.GroupBox groupBoxArtikli;
        private System.Windows.Forms.GroupBox groupBoxKorpa;
        private System.Windows.Forms.TextBox textBoxUkupnoNarudzba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKorpa;
        private System.Windows.Forms.Button buttonDodajUKorpu;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Button buttonUkloniIzKorpe;
        private System.Windows.Forms.TextBox textBoxIDArtikla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKreirajNarudzbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalNaziv;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponudaArtikalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponudaArtikalNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponudaCijenaArtikalKomad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponudaArtikalKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpaArtikalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpaArtikalNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpaCijenaArtikalKomad;
        private System.Windows.Forms.DataGridViewButtonColumn korpaOduzmi1Komad;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpaArtikalKolicina;
        private System.Windows.Forms.DataGridViewButtonColumn korpaDodaj1Komad;
        private System.Windows.Forms.DataGridViewTextBoxColumn korpaCijenaArtikalUkupno;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}