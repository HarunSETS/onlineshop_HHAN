namespace prodaja_HHAN
{
    partial class FormAdmNarudzbi
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
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.groupBoxBrisanje = new System.Windows.Forms.GroupBox();
            this.buttonNarudzbeBrisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNazivAzuriranje = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.groupBoxPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            this.groupBoxBrisanje.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(723, 24);
            this.menuStrip.TabIndex = 31;
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
            this.ToolStripMenuItemAdmArtikala.Name = "ToolStripMenuItemAdmArtikala";
            this.ToolStripMenuItemAdmArtikala.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemAdmArtikala.Text = "Administracija artikala";
            this.ToolStripMenuItemAdmArtikala.Click += new System.EventHandler(this.ToolStripMenuItemAdmArtikala_Click_1);
            // 
            // ToolStripMenuItemPregledBrisanjeNarudzbi
            // 
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Enabled = false;
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Name = "ToolStripMenuItemPregledBrisanjeNarudzbi";
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Text = "Pregled i brisanje narudžbi";
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
            this.labelKorisnikInfo.Location = new System.Drawing.Point(401, 5);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(134, 14);
            this.labelKorisnikInfo.TabIndex = 32;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.dataGridViewNarudzbe);
            this.groupBoxPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPretraga.Location = new System.Drawing.Point(12, 33);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(699, 151);
            this.groupBoxPretraga.TabIndex = 59;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "Pregled narudžbi svih korisnika";
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AllowUserToAddRows = false;
            this.dataGridViewNarudzbe.AllowUserToDeleteRows = false;
            this.dataGridViewNarudzbe.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(15, 20);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.ReadOnly = true;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(669, 115);
            this.dataGridViewNarudzbe.TabIndex = 41;
            // 
            // groupBoxBrisanje
            // 
            this.groupBoxBrisanje.Controls.Add(this.buttonNarudzbeBrisi);
            this.groupBoxBrisanje.Controls.Add(this.label8);
            this.groupBoxBrisanje.Controls.Add(this.textBoxNazivAzuriranje);
            this.groupBoxBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxBrisanje.Location = new System.Drawing.Point(12, 190);
            this.groupBoxBrisanje.Name = "groupBoxBrisanje";
            this.groupBoxBrisanje.Size = new System.Drawing.Size(699, 69);
            this.groupBoxBrisanje.TabIndex = 60;
            this.groupBoxBrisanje.TabStop = false;
            this.groupBoxBrisanje.Text = "Brisanje odabrane narudžbe sa njenim stavkama";
            // 
            // buttonNarudzbeBrisi
            // 
            this.buttonNarudzbeBrisi.BackColor = System.Drawing.Color.Moccasin;
            this.buttonNarudzbeBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNarudzbeBrisi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNarudzbeBrisi.Location = new System.Drawing.Point(462, 26);
            this.buttonNarudzbeBrisi.Name = "buttonNarudzbeBrisi";
            this.buttonNarudzbeBrisi.Size = new System.Drawing.Size(222, 28);
            this.buttonNarudzbeBrisi.TabIndex = 78;
            this.buttonNarudzbeBrisi.Text = "Obriši narudžbu i njene stavke";
            this.buttonNarudzbeBrisi.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Sistemski ID narudžbe";
            // 
            // textBoxNazivAzuriranje
            // 
            this.textBoxNazivAzuriranje.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNazivAzuriranje.Location = new System.Drawing.Point(138, 31);
            this.textBoxNazivAzuriranje.Name = "textBoxNazivAzuriranje";
            this.textBoxNazivAzuriranje.Size = new System.Drawing.Size(132, 21);
            this.textBoxNazivAzuriranje.TabIndex = 76;
            // 
            // FormAdmNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 271);
            this.Controls.Add(this.groupBoxBrisanje);
            this.Controls.Add(this.groupBoxPretraga);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAdmNarudzbi";
            this.Text = "ADMINISTRATOR - Pregled i brisanje narudžbi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmNarudzbi_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmNarudzbi_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxPretraga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            this.groupBoxBrisanje.ResumeLayout(false);
            this.groupBoxBrisanje.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.GroupBox groupBoxBrisanje;
        private System.Windows.Forms.Button buttonNarudzbeBrisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNazivAzuriranje;

    }
}