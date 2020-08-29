namespace WFA_HastaneRandevuOtomasyonu
{
    partial class frmMenu
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pbxRandevuListesi = new System.Windows.Forms.PictureBox();
            this.pbxRandevu = new System.Windows.Forms.PictureBox();
            this.pbxDoktor = new System.Windows.Forms.PictureBox();
            this.pbxBrans = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRandevuListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(12, 5);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 25);
            this.lblKullaniciAdi.TabIndex = 8;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCikis.Location = new System.Drawing.Point(297, 5);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(32, 31);
            this.btnCikis.TabIndex = 31;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pbxRandevuListesi
            // 
            this.pbxRandevuListesi.Image = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources._233_2339018_search_icon_png_circle_clipart_removebg_preview;
            this.pbxRandevuListesi.Location = new System.Drawing.Point(178, 188);
            this.pbxRandevuListesi.Name = "pbxRandevuListesi";
            this.pbxRandevuListesi.Size = new System.Drawing.Size(120, 120);
            this.pbxRandevuListesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRandevuListesi.TabIndex = 7;
            this.pbxRandevuListesi.TabStop = false;
            this.pbxRandevuListesi.WaitOnLoad = true;
            // 
            // pbxRandevu
            // 
            this.pbxRandevu.Image = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources.images__1__removebg_preview;
            this.pbxRandevu.Location = new System.Drawing.Point(43, 188);
            this.pbxRandevu.Name = "pbxRandevu";
            this.pbxRandevu.Size = new System.Drawing.Size(120, 120);
            this.pbxRandevu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRandevu.TabIndex = 6;
            this.pbxRandevu.TabStop = false;
            this.pbxRandevu.WaitOnLoad = true;
            // 
            // pbxDoktor
            // 
            this.pbxDoktor.Image = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources._34_340401_doctor_icon_png_clip_library_stock_doctor_icon_removebg_preview;
            this.pbxDoktor.Location = new System.Drawing.Point(178, 62);
            this.pbxDoktor.Name = "pbxDoktor";
            this.pbxDoktor.Size = new System.Drawing.Size(120, 120);
            this.pbxDoktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDoktor.TabIndex = 5;
            this.pbxDoktor.TabStop = false;
            this.pbxDoktor.WaitOnLoad = true;
            // 
            // pbxBrans
            // 
            this.pbxBrans.Image = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources.BB_teal_icon_4;
            this.pbxBrans.Location = new System.Drawing.Point(43, 62);
            this.pbxBrans.Name = "pbxBrans";
            this.pbxBrans.Size = new System.Drawing.Size(120, 120);
            this.pbxBrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrans.TabIndex = 4;
            this.pbxBrans.TabStop = false;
            this.pbxBrans.WaitOnLoad = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(341, 341);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.pbxRandevuListesi);
            this.Controls.Add(this.pbxRandevu);
            this.Controls.Add(this.pbxDoktor);
            this.Controls.Add(this.pbxBrans);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRandevuListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxRandevuListesi;
        private System.Windows.Forms.PictureBox pbxRandevu;
        private System.Windows.Forms.PictureBox pbxDoktor;
        private System.Windows.Forms.PictureBox pbxBrans;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Label lblKullaniciAdi;
    }
}

