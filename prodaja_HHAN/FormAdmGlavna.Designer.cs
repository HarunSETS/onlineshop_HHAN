﻿namespace prodaja_HHAN
{
    partial class FormAdmGlavna
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
            this.buttonAdmNarudzbe = new System.Windows.Forms.Button();
            this.buttonAdmKupci = new System.Windows.Forms.Button();
            this.buttonAdmArtikli = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdmKupaca = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdmArtikala = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPregledBrisanjeNarudzbi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelKorisnikInfo = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdmNarudzbe
            // 
            this.buttonAdmNarudzbe.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAdmNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmNarudzbe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmNarudzbe.Location = new System.Drawing.Point(352, 215);
            this.buttonAdmNarudzbe.Name = "buttonAdmNarudzbe";
            this.buttonAdmNarudzbe.Size = new System.Drawing.Size(216, 58);
            this.buttonAdmNarudzbe.TabIndex = 14;
            this.buttonAdmNarudzbe.Text = "Pregled i brisanje narudžbi";
            this.buttonAdmNarudzbe.UseVisualStyleBackColor = false;
            this.buttonAdmNarudzbe.Click += new System.EventHandler(this.buttonAdmNarudzbe_Click);
            // 
            // buttonAdmKupci
            // 
            this.buttonAdmKupci.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAdmKupci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmKupci.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmKupci.Location = new System.Drawing.Point(352, 73);
            this.buttonAdmKupci.Name = "buttonAdmKupci";
            this.buttonAdmKupci.Size = new System.Drawing.Size(216, 58);
            this.buttonAdmKupci.TabIndex = 15;
            this.buttonAdmKupci.Text = "Administracija korisnika";
            this.buttonAdmKupci.UseVisualStyleBackColor = false;
            this.buttonAdmKupci.Click += new System.EventHandler(this.buttonAdmKupci_Click);
            // 
            // buttonAdmArtikli
            // 
            this.buttonAdmArtikli.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAdmArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmArtikli.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmArtikli.Location = new System.Drawing.Point(352, 144);
            this.buttonAdmArtikli.Name = "buttonAdmArtikli";
            this.buttonAdmArtikli.Size = new System.Drawing.Size(216, 58);
            this.buttonAdmArtikli.TabIndex = 16;
            this.buttonAdmArtikli.Text = "Administracija artikala";
            this.buttonAdmArtikli.UseVisualStyleBackColor = false;
            this.buttonAdmArtikli.Click += new System.EventHandler(this.buttonAdmArtikli_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(614, 26);
            this.menuStrip.TabIndex = 28;
            this.menuStrip.Text = "Glavni meni";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAdmKupaca,
            this.ToolStripMenuItemAdmArtikala,
            this.ToolStripMenuItemPregledBrisanjeNarudzbi,
            this.ToolStripMenuItemOdjava});
            this.meniToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // ToolStripMenuItemAdmKupaca
            // 
            this.ToolStripMenuItemAdmKupaca.Name = "ToolStripMenuItemAdmKupaca";
            this.ToolStripMenuItemAdmKupaca.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemAdmKupaca.Text = "Administracija korisnika";
            this.ToolStripMenuItemAdmKupaca.Click += new System.EventHandler(this.ToolStripMenuItemAdmKupaca_Click);
            // 
            // ToolStripMenuItemAdmArtikala
            // 
            this.ToolStripMenuItemAdmArtikala.Name = "ToolStripMenuItemAdmArtikala";
            this.ToolStripMenuItemAdmArtikala.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemAdmArtikala.Text = "Administracija artikala";
            this.ToolStripMenuItemAdmArtikala.Click += new System.EventHandler(this.ToolStripMenuItemAdmArtikala_Click);
            // 
            // ToolStripMenuItemPregledBrisanjeNarudzbi
            // 
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Name = "ToolStripMenuItemPregledBrisanjeNarudzbi";
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Text = "Pregled i brisanje narudžbi";
            this.ToolStripMenuItemPregledBrisanjeNarudzbi.Click += new System.EventHandler(this.ToolStripMenuItemPregledBrisanjeNarudzbi_Click);
            // 
            // ToolStripMenuItemOdjava
            // 
            this.ToolStripMenuItemOdjava.Name = "ToolStripMenuItemOdjava";
            this.ToolStripMenuItemOdjava.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemOdjava.Text = "Odjava iz aplikacije";
            this.ToolStripMenuItemOdjava.Click += new System.EventHandler(this.ToolStripMenuItemOdjava_Click);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogin.Image = global::prodaja_HHAN.Properties.Resources.glavna_pozadina;
            this.pictureBoxLogin.Location = new System.Drawing.Point(1, 27);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(291, 272);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 13;
            this.pictureBoxLogin.TabStop = false;
            // 
            // labelKorisnikInfo
            // 
            this.labelKorisnikInfo.AutoSize = true;
            this.labelKorisnikInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelKorisnikInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnikInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelKorisnikInfo.Location = new System.Drawing.Point(354, 6);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(150, 18);
            this.labelKorisnikInfo.TabIndex = 29;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // FormAdmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 301);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.buttonAdmArtikli);
            this.Controls.Add(this.buttonAdmKupci);
            this.Controls.Add(this.buttonAdmNarudzbe);
            this.Controls.Add(this.pictureBoxLogin);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAdmGlavna";
            this.Text = "ADMINISTRATOR - Glavni ekran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmGlavna_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmGlavna_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button buttonAdmNarudzbe;
        private System.Windows.Forms.Button buttonAdmKupci;
        private System.Windows.Forms.Button buttonAdmArtikli;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdmKupaca;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdmArtikala;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPregledBrisanjeNarudzbi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOdjava;
        private System.Windows.Forms.Label labelKorisnikInfo;
    }
}