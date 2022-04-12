namespace prodaja_HHAN
{
    partial class FormKupPregledNarudzbi
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
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNarudzbeStavke = new System.Windows.Forms.DataGridView();
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.buttonKupciTrazi = new System.Windows.Forms.Button();
            this.labelNarudzbaIDTrazi = new System.Windows.Forms.Label();
            this.textBoxNarudzbaIDTrazi = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.groupBoxPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbeStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(710, 24);
            this.menuStrip.TabIndex = 34;
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
            this.ToolStripMenuItemKreiranjeNarudzbe.Name = "ToolStripMenuItemKreiranjeNarudzbe";
            this.ToolStripMenuItemKreiranjeNarudzbe.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemKreiranjeNarudzbe.Text = "Kreiranje narudžbi";
            this.ToolStripMenuItemKreiranjeNarudzbe.Click += new System.EventHandler(this.ToolStripMenuItemKreiranjeNarudzbe_Click);
            // 
            // ToolStripMenuItemPregledNarudzbi
            // 
            this.ToolStripMenuItemPregledNarudzbi.Enabled = false;
            this.ToolStripMenuItemPregledNarudzbi.Name = "ToolStripMenuItemPregledNarudzbi";
            this.ToolStripMenuItemPregledNarudzbi.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemPregledNarudzbi.Text = "Pregled narudžbi";
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
            this.labelKorisnikInfo.Location = new System.Drawing.Point(381, 5);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(134, 14);
            this.labelKorisnikInfo.TabIndex = 35;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.textBoxTotal);
            this.groupBoxPretraga.Controls.Add(this.label3);
            this.groupBoxPretraga.Controls.Add(this.label2);
            this.groupBoxPretraga.Controls.Add(this.label1);
            this.groupBoxPretraga.Controls.Add(this.dataGridViewNarudzbeStavke);
            this.groupBoxPretraga.Controls.Add(this.dataGridViewNarudzbe);
            this.groupBoxPretraga.Controls.Add(this.buttonKupciTrazi);
            this.groupBoxPretraga.Controls.Add(this.labelNarudzbaIDTrazi);
            this.groupBoxPretraga.Controls.Add(this.textBoxNarudzbaIDTrazi);
            this.groupBoxPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPretraga.Location = new System.Drawing.Point(12, 36);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(683, 281);
            this.groupBoxPretraga.TabIndex = 39;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "Pregled vaših ranijih narudžbi";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(570, 243);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(93, 21);
            this.textBoxTotal.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Total za odabranu narudžbu (KM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "= >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Prikaz stavki odabrane narudžbe";
            // 
            // dataGridViewNarudzbeStavke
            // 
            this.dataGridViewNarudzbeStavke.AllowUserToAddRows = false;
            this.dataGridViewNarudzbeStavke.AllowUserToDeleteRows = false;
            this.dataGridViewNarudzbeStavke.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewNarudzbeStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbeStavke.Location = new System.Drawing.Point(396, 51);
            this.dataGridViewNarudzbeStavke.MultiSelect = false;
            this.dataGridViewNarudzbeStavke.Name = "dataGridViewNarudzbeStavke";
            this.dataGridViewNarudzbeStavke.ReadOnly = true;
            this.dataGridViewNarudzbeStavke.RowHeadersVisible = false;
            this.dataGridViewNarudzbeStavke.Size = new System.Drawing.Size(267, 184);
            this.dataGridViewNarudzbeStavke.TabIndex = 42;
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AllowUserToAddRows = false;
            this.dataGridViewNarudzbe.AllowUserToDeleteRows = false;
            this.dataGridViewNarudzbe.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(16, 24);
            this.dataGridViewNarudzbe.MultiSelect = false;
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.ReadOnly = true;
            this.dataGridViewNarudzbe.RowHeadersVisible = false;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(301, 211);
            this.dataGridViewNarudzbe.TabIndex = 41;
            // 
            // buttonKupciTrazi
            // 
            this.buttonKupciTrazi.BackColor = System.Drawing.Color.LightCyan;
            this.buttonKupciTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKupciTrazi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKupciTrazi.Location = new System.Drawing.Point(236, 243);
            this.buttonKupciTrazi.Name = "buttonKupciTrazi";
            this.buttonKupciTrazi.Size = new System.Drawing.Size(81, 24);
            this.buttonKupciTrazi.TabIndex = 40;
            this.buttonKupciTrazi.Text = "Traži ...";
            this.buttonKupciTrazi.UseVisualStyleBackColor = false;
            // 
            // labelNarudzbaIDTrazi
            // 
            this.labelNarudzbaIDTrazi.AutoSize = true;
            this.labelNarudzbaIDTrazi.Location = new System.Drawing.Point(13, 247);
            this.labelNarudzbaIDTrazi.Name = "labelNarudzbaIDTrazi";
            this.labelNarudzbaIDTrazi.Size = new System.Drawing.Size(110, 13);
            this.labelNarudzbaIDTrazi.TabIndex = 38;
            this.labelNarudzbaIDTrazi.Text = "Sistemski ID narudžbe";
            // 
            // textBoxNarudzbaIDTrazi
            // 
            this.textBoxNarudzbaIDTrazi.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNarudzbaIDTrazi.Location = new System.Drawing.Point(148, 243);
            this.textBoxNarudzbaIDTrazi.Name = "textBoxNarudzbaIDTrazi";
            this.textBoxNarudzbaIDTrazi.Size = new System.Drawing.Size(80, 21);
            this.textBoxNarudzbaIDTrazi.TabIndex = 36;
            // 
            // FormKupPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 332);
            this.Controls.Add(this.groupBoxPretraga);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormKupPregledNarudzbi";
            this.Text = "Pregled narudžbi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKupPregledNarudzbi_FormClosed);
            this.Load += new System.EventHandler(this.FormKupPregledNarudzbi_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxPretraga.ResumeLayout(false);
            this.groupBoxPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbeStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbeStavke;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.Button buttonKupciTrazi;
        private System.Windows.Forms.Label labelNarudzbaIDTrazi;
        private System.Windows.Forms.TextBox textBoxNarudzbaIDTrazi;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}