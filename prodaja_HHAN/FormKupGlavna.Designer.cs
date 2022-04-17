namespace prodaja_HHAN
{
    partial class FormKupGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKupGlavna));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKreiranjeNarudzbe = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPregledNarudzbi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPregledNarudzbi = new System.Windows.Forms.Button();
            this.buttonKreiranjeNarudzbe = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelKorisnikInfo = new System.Windows.Forms.Label();
            this.timerZaSliku = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(598, 24);
            this.menuStrip.TabIndex = 32;
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
            // buttonPregledNarudzbi
            // 
            this.buttonPregledNarudzbi.BackColor = System.Drawing.Color.Moccasin;
            this.buttonPregledNarudzbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPregledNarudzbi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPregledNarudzbi.Location = new System.Drawing.Point(352, 145);
            this.buttonPregledNarudzbi.Name = "buttonPregledNarudzbi";
            this.buttonPregledNarudzbi.Size = new System.Drawing.Size(216, 54);
            this.buttonPregledNarudzbi.TabIndex = 31;
            this.buttonPregledNarudzbi.Text = "Pregled narudžbi";
            this.buttonPregledNarudzbi.UseVisualStyleBackColor = false;
            this.buttonPregledNarudzbi.Click += new System.EventHandler(this.buttonPregledNarudzbi_Click);
            // 
            // buttonKreiranjeNarudzbe
            // 
            this.buttonKreiranjeNarudzbe.BackColor = System.Drawing.Color.Moccasin;
            this.buttonKreiranjeNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKreiranjeNarudzbe.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreiranjeNarudzbe.Location = new System.Drawing.Point(352, 74);
            this.buttonKreiranjeNarudzbe.Name = "buttonKreiranjeNarudzbe";
            this.buttonKreiranjeNarudzbe.Size = new System.Drawing.Size(216, 54);
            this.buttonKreiranjeNarudzbe.TabIndex = 30;
            this.buttonKreiranjeNarudzbe.Text = "Kreiranje narudžbe";
            this.buttonKreiranjeNarudzbe.UseVisualStyleBackColor = false;
            this.buttonKreiranjeNarudzbe.Click += new System.EventHandler(this.buttonKreiranjeNarudzbe_Click);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(1, 25);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(291, 272);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 29;
            this.pictureBoxLogin.TabStop = false;
            // 
            // labelKorisnikInfo
            // 
            this.labelKorisnikInfo.AutoSize = true;
            this.labelKorisnikInfo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelKorisnikInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnikInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelKorisnikInfo.Location = new System.Drawing.Point(353, 5);
            this.labelKorisnikInfo.Name = "labelKorisnikInfo";
            this.labelKorisnikInfo.Size = new System.Drawing.Size(134, 14);
            this.labelKorisnikInfo.TabIndex = 33;
            this.labelKorisnikInfo.Text = "prijavljeni korisnik info";
            // 
            // timerZaSliku
            // 
            this.timerZaSliku.Interval = 1000;
            this.timerZaSliku.Tick += new System.EventHandler(this.timerZaSliku_Tick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::prodaja_HHAN.Properties.Resources.hhanlogo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(294, 274);
            this.pictureBoxLogo.TabIndex = 34;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Visible = false;
            // 
            // FormKupGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 303);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelKorisnikInfo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.buttonPregledNarudzbi);
            this.Controls.Add(this.buttonKreiranjeNarudzbe);
            this.Controls.Add(this.pictureBoxLogin);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormKupGlavna";
            this.Text = "Želimo vam ugodnu kupovinu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKupGlavna_FormClosed);
            this.Load += new System.EventHandler(this.FormKupGlavna_Load);
            this.VisibleChanged += new System.EventHandler(this.FormLogin_VisibleChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKreiranjeNarudzbe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPregledNarudzbi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOdjava;
        private System.Windows.Forms.Button buttonPregledNarudzbi;
        private System.Windows.Forms.Button buttonKreiranjeNarudzbe;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelKorisnikInfo;
        private System.Windows.Forms.Timer timerZaSliku;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}