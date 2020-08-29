namespace WFA_HastaneRandevuOtomasyonu
{
    partial class frmRandevuListele
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTCNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clmSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDoktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTCNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwRandevuListesi = new System.Windows.Forms.ListView();
            this.clmBrans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRandevuListele = new System.Windows.Forms.Button();
            this.btRandevuAlGbx = new System.Windows.Forms.Button();
            this.btnDoktorEkleGbx = new System.Windows.Forms.Button();
            this.btnBransEkleGbx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "TC No :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTCNo
            // 
            this.tbxTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTCNo.Location = new System.Drawing.Point(80, 17);
            this.tbxTCNo.Name = "tbxTCNo";
            this.tbxTCNo.Size = new System.Drawing.Size(158, 23);
            this.tbxTCNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.tbxTCNo);
            this.groupBox2.Location = new System.Drawing.Point(11, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 48);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // clmSaat
            // 
            this.clmSaat.Text = "Saat";
            this.clmSaat.Width = 84;
            // 
            // clmTarih
            // 
            this.clmTarih.Text = "Tarih";
            this.clmTarih.Width = 111;
            // 
            // clmDoktor
            // 
            this.clmDoktor.Text = "Doktor";
            this.clmDoktor.Width = 122;
            // 
            // clmSoyad
            // 
            this.clmSoyad.Text = "Soyadı";
            this.clmSoyad.Width = 93;
            // 
            // clmAd
            // 
            this.clmAd.Text = "Adı";
            this.clmAd.Width = 128;
            // 
            // clmTCNo
            // 
            this.clmTCNo.Text = "TCNo";
            this.clmTCNo.Width = 147;
            // 
            // lwRandevuListesi
            // 
            this.lwRandevuListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lwRandevuListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTCNo,
            this.clmAd,
            this.clmSoyad,
            this.clmBrans,
            this.clmDoktor,
            this.clmTarih,
            this.clmSaat});
            this.lwRandevuListesi.ForeColor = System.Drawing.SystemColors.Control;
            this.lwRandevuListesi.GridLines = true;
            this.lwRandevuListesi.HideSelection = false;
            this.lwRandevuListesi.Location = new System.Drawing.Point(11, 110);
            this.lwRandevuListesi.Margin = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.lwRandevuListesi.Name = "lwRandevuListesi";
            this.lwRandevuListesi.Size = new System.Drawing.Size(816, 275);
            this.lwRandevuListesi.TabIndex = 32;
            this.lwRandevuListesi.UseCompatibleStateImageBehavior = false;
            this.lwRandevuListesi.View = System.Windows.Forms.View.Details;
            // 
            // clmBrans
            // 
            this.clmBrans.Text = "Branş";
            this.clmBrans.Width = 127;
            // 
            // btRandevuListele
            // 
            this.btRandevuListele.BackColor = System.Drawing.Color.Black;
            this.btRandevuListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRandevuListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRandevuListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btRandevuListele.Location = new System.Drawing.Point(347, 13);
            this.btRandevuListele.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btRandevuListele.Name = "btRandevuListele";
            this.btRandevuListele.Size = new System.Drawing.Size(101, 27);
            this.btRandevuListele.TabIndex = 29;
            this.btRandevuListele.Text = "Randevuları Listele";
            this.btRandevuListele.UseVisualStyleBackColor = false;
            // 
            // btRandevuAlGbx
            // 
            this.btRandevuAlGbx.BackColor = System.Drawing.Color.Black;
            this.btRandevuAlGbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRandevuAlGbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRandevuAlGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.btRandevuAlGbx.Location = new System.Drawing.Point(235, 13);
            this.btRandevuAlGbx.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btRandevuAlGbx.Name = "btRandevuAlGbx";
            this.btRandevuAlGbx.Size = new System.Drawing.Size(101, 27);
            this.btRandevuAlGbx.TabIndex = 28;
            this.btRandevuAlGbx.Text = "Randevu Al";
            this.btRandevuAlGbx.UseVisualStyleBackColor = false;
            // 
            // btnDoktorEkleGbx
            // 
            this.btnDoktorEkleGbx.BackColor = System.Drawing.Color.Black;
            this.btnDoktorEkleGbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorEkleGbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkleGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorEkleGbx.Location = new System.Drawing.Point(124, 13);
            this.btnDoktorEkleGbx.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnDoktorEkleGbx.Name = "btnDoktorEkleGbx";
            this.btnDoktorEkleGbx.Size = new System.Drawing.Size(101, 27);
            this.btnDoktorEkleGbx.TabIndex = 27;
            this.btnDoktorEkleGbx.Text = "Doktor Ekle";
            this.btnDoktorEkleGbx.UseVisualStyleBackColor = false;
            // 
            // btnBransEkleGbx
            // 
            this.btnBransEkleGbx.BackColor = System.Drawing.Color.Black;
            this.btnBransEkleGbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBransEkleGbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBransEkleGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBransEkleGbx.Location = new System.Drawing.Point(13, 13);
            this.btnBransEkleGbx.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnBransEkleGbx.Name = "btnBransEkleGbx";
            this.btnBransEkleGbx.Size = new System.Drawing.Size(101, 27);
            this.btnBransEkleGbx.TabIndex = 26;
            this.btnBransEkleGbx.Text = "Branş Ekle";
            this.btnBransEkleGbx.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRandevuListele);
            this.groupBox1.Controls.Add(this.btRandevuAlGbx);
            this.groupBox1.Controls.Add(this.btnDoktorEkleGbx);
            this.groupBox1.Controls.Add(this.btnBransEkleGbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 48);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAra.BackgroundImage = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources._233_2339018_search_icon_png_circle_clipart_removebg_preview;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAra.Location = new System.Drawing.Point(778, 12);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(32, 31);
            this.btnAra.TabIndex = 1;
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // frmRandevuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(839, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lwRandevuListesi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmRandevuListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRandevuListele";
            this.Load += new System.EventHandler(this.frmRandevuListele_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox tbxTCNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader clmSaat;
        private System.Windows.Forms.ColumnHeader clmTarih;
        private System.Windows.Forms.ColumnHeader clmDoktor;
        private System.Windows.Forms.ColumnHeader clmSoyad;
        private System.Windows.Forms.ColumnHeader clmAd;
        private System.Windows.Forms.ColumnHeader clmTCNo;
        private System.Windows.Forms.ListView lwRandevuListesi;
        private System.Windows.Forms.ColumnHeader clmBrans;
        private System.Windows.Forms.Button btRandevuListele;
        private System.Windows.Forms.Button btRandevuAlGbx;
        private System.Windows.Forms.Button btnDoktorEkleGbx;
        private System.Windows.Forms.Button btnBransEkleGbx;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}