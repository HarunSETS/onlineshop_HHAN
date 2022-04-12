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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKreiranjeNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPregledNarudzbi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.MeniToolStripMenuItemGlavniKupMeni = new System.Windows.Forms.ToolStripMenuItem();
            this.labelKorisnikInfo = new System.Windows.Forms.Label();
            this.groupBoxArtikli = new System.Windows.Forms.GroupBox();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.groupBoxKorpa = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKorpa = new System.Windows.Forms.DataGridView();
            this.buttonAdmKupci = new System.Windows.Forms.Button();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxImeAzuriranje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBoxArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.groupBoxKorpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
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
            this.labelKorisnikInfo.Location = new System.Drawing.Point(383, 5);
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
            this.groupBoxArtikli.Size = new System.Drawing.Size(257, 256);
            this.groupBoxArtikli.TabIndex = 40;
            this.groupBoxArtikli.TabStop = false;
            this.groupBoxArtikli.Text = "Raspoloživi artikli";
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AllowUserToAddRows = false;
            this.dataGridViewArtikli.AllowUserToDeleteRows = false;
            this.dataGridViewArtikli.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(16, 24);
            this.dataGridViewArtikli.MultiSelect = false;
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            this.dataGridViewArtikli.RowHeadersVisible = false;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(221, 191);
            this.dataGridViewArtikli.TabIndex = 41;
            // 
            // groupBoxKorpa
            // 
            this.groupBoxKorpa.Controls.Add(this.textBox1);
            this.groupBoxKorpa.Controls.Add(this.label4);
            this.groupBoxKorpa.Controls.Add(this.dataGridViewKorpa);
            this.groupBoxKorpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxKorpa.Location = new System.Drawing.Point(497, 45);
            this.groupBoxKorpa.Name = "groupBoxKorpa";
            this.groupBoxKorpa.Size = new System.Drawing.Size(294, 249);
            this.groupBoxKorpa.TabIndex = 41;
            this.groupBoxKorpa.TabStop = false;
            this.groupBoxKorpa.Text = "Korpa";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(184, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 21);
            this.textBox1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 220);
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
            this.dataGridViewKorpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorpa.Location = new System.Drawing.Point(10, 24);
            this.dataGridViewKorpa.MultiSelect = false;
            this.dataGridViewKorpa.Name = "dataGridViewKorpa";
            this.dataGridViewKorpa.ReadOnly = true;
            this.dataGridViewKorpa.RowHeadersVisible = false;
            this.dataGridViewKorpa.Size = new System.Drawing.Size(267, 184);
            this.dataGridViewKorpa.TabIndex = 42;
            // 
            // buttonAdmKupci
            // 
            this.buttonAdmKupci.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAdmKupci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmKupci.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmKupci.Location = new System.Drawing.Point(285, 84);
            this.buttonAdmKupci.Name = "buttonAdmKupci";
            this.buttonAdmKupci.Size = new System.Drawing.Size(190, 38);
            this.buttonAdmKupci.TabIndex = 42;
            this.buttonAdmKupci.Text = "=>  Dodaj artikl u korpu   =>";
            this.buttonAdmKupci.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdmKupci.UseVisualStyleBackColor = false;
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownKolicina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownKolicina.Location = new System.Drawing.Point(386, 160);
            this.numericUpDownKolicina.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(89, 27);
            this.numericUpDownKolicina.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 126;
            this.button1.Text = "<=  Ukloni artikl iz korpe   <=";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxImeAzuriranje
            // 
            this.textBoxImeAzuriranje.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxImeAzuriranje.Enabled = false;
            this.textBoxImeAzuriranje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeAzuriranje.Location = new System.Drawing.Point(285, 160);
            this.textBoxImeAzuriranje.Name = "textBoxImeAzuriranje";
            this.textBoxImeAzuriranje.Size = new System.Drawing.Size(86, 27);
            this.textBoxImeAzuriranje.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "ID artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Količina";
            // 
            // FormKupKreiranjeNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImeAzuriranje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownKolicina);
            this.Controls.Add(this.buttonAdmKupci);
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
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.GroupBox groupBoxKorpa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKorpa;
        private System.Windows.Forms.Button buttonAdmKupci;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxImeAzuriranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}