﻿namespace WFA_HastaneRandevuOtomasyonu
{
    partial class frmDoktorListele
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cbxDoktorListe = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxBransListe = new System.Windows.Forms.ComboBox();
            this.clmRandevuSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDeneyim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDoktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwRandevuListesi = new System.Windows.Forms.ListView();
            this.clmBrans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRandevuListeleForm = new System.Windows.Forms.Button();
            this.btRandevuAlForm = new System.Windows.Forms.Button();
            this.btnDoktorEkleForm = new System.Windows.Forms.Button();
            this.btnBransEkleForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Branş :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Doktor :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnAra.TabIndex = 30;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cbxDoktorListe
            // 
            this.cbxDoktorListe.FormattingEnabled = true;
            this.cbxDoktorListe.Location = new System.Drawing.Point(331, 17);
            this.cbxDoktorListe.Name = "cbxDoktorListe";
            this.cbxDoktorListe.Size = new System.Drawing.Size(158, 23);
            this.cbxDoktorListe.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.cbxDoktorListe);
            this.groupBox2.Controls.Add(this.cbxBransListe);
            this.groupBox2.Location = new System.Drawing.Point(11, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 48);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // cbxBransListe
            // 
            this.cbxBransListe.FormattingEnabled = true;
            this.cbxBransListe.Location = new System.Drawing.Point(80, 17);
            this.cbxBransListe.Name = "cbxBransListe";
            this.cbxBransListe.Size = new System.Drawing.Size(158, 23);
            this.cbxBransListe.TabIndex = 1;
            this.cbxBransListe.SelectedIndexChanged += new System.EventHandler(this.cbxBransListe_SelectedIndexChanged);
            // 
            // clmRandevuSayisi
            // 
            this.clmRandevuSayisi.Text = "Randevu Sayısı";
            this.clmRandevuSayisi.Width = 183;
            // 
            // clmDeneyim
            // 
            this.clmDeneyim.Text = "Deneyimi";
            this.clmDeneyim.Width = 187;
            // 
            // clmDoktor
            // 
            this.clmDoktor.Text = "Doktor Ad";
            this.clmDoktor.Width = 204;
            // 
            // lwRandevuListesi
            // 
            this.lwRandevuListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lwRandevuListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmBrans,
            this.clmDoktor,
            this.clmDeneyim,
            this.clmRandevuSayisi});
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
            this.clmBrans.Width = 238;
            // 
            // btnRandevuListeleForm
            // 
            this.btnRandevuListeleForm.BackColor = System.Drawing.Color.Black;
            this.btnRandevuListeleForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuListeleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuListeleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRandevuListeleForm.Location = new System.Drawing.Point(347, 13);
            this.btnRandevuListeleForm.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnRandevuListeleForm.Name = "btnRandevuListeleForm";
            this.btnRandevuListeleForm.Size = new System.Drawing.Size(101, 27);
            this.btnRandevuListeleForm.TabIndex = 29;
            this.btnRandevuListeleForm.Text = "Randevuları Listele";
            this.btnRandevuListeleForm.UseVisualStyleBackColor = false;
            this.btnRandevuListeleForm.Click += new System.EventHandler(this.btRandevuListeleForm_Click);
            // 
            // btRandevuAlForm
            // 
            this.btRandevuAlForm.BackColor = System.Drawing.Color.Black;
            this.btRandevuAlForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRandevuAlForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRandevuAlForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btRandevuAlForm.Location = new System.Drawing.Point(235, 13);
            this.btRandevuAlForm.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btRandevuAlForm.Name = "btRandevuAlForm";
            this.btRandevuAlForm.Size = new System.Drawing.Size(101, 27);
            this.btRandevuAlForm.TabIndex = 28;
            this.btRandevuAlForm.Text = "Randevu Al";
            this.btRandevuAlForm.UseVisualStyleBackColor = false;
            this.btRandevuAlForm.Click += new System.EventHandler(this.btRandevuAlForm_Click);
            // 
            // btnDoktorEkleForm
            // 
            this.btnDoktorEkleForm.BackColor = System.Drawing.Color.Black;
            this.btnDoktorEkleForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorEkleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorEkleForm.Location = new System.Drawing.Point(124, 13);
            this.btnDoktorEkleForm.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnDoktorEkleForm.Name = "btnDoktorEkleForm";
            this.btnDoktorEkleForm.Size = new System.Drawing.Size(101, 27);
            this.btnDoktorEkleForm.TabIndex = 27;
            this.btnDoktorEkleForm.Text = "Doktor Ekle";
            this.btnDoktorEkleForm.UseVisualStyleBackColor = false;
            this.btnDoktorEkleForm.Click += new System.EventHandler(this.btnDoktorEkleForm_Click);
            // 
            // btnBransEkleForm
            // 
            this.btnBransEkleForm.BackColor = System.Drawing.Color.Black;
            this.btnBransEkleForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBransEkleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBransEkleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBransEkleForm.Location = new System.Drawing.Point(13, 13);
            this.btnBransEkleForm.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnBransEkleForm.Name = "btnBransEkleForm";
            this.btnBransEkleForm.Size = new System.Drawing.Size(101, 27);
            this.btnBransEkleForm.TabIndex = 26;
            this.btnBransEkleForm.Text = "Branş Ekle";
            this.btnBransEkleForm.UseVisualStyleBackColor = false;
            this.btnBransEkleForm.Click += new System.EventHandler(this.btnBransEkleForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuDon);
            this.groupBox1.Controls.Add(this.btnRandevuListeleForm);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btRandevuAlForm);
            this.groupBox1.Controls.Add(this.btnDoktorEkleForm);
            this.groupBox1.Controls.Add(this.btnBransEkleForm);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 48);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // btnMenuDon
            // 
            this.btnMenuDon.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuDon.BackgroundImage = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources.back;
            this.btnMenuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuDon.FlatAppearance.BorderSize = 0;
            this.btnMenuDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDon.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuDon.Location = new System.Drawing.Point(740, 11);
            this.btnMenuDon.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnMenuDon.Name = "btnMenuDon";
            this.btnMenuDon.Size = new System.Drawing.Size(32, 31);
            this.btnMenuDon.TabIndex = 37;
            this.btnMenuDon.UseVisualStyleBackColor = false;
            this.btnMenuDon.Click += new System.EventHandler(this.btnMenuDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::WFA_HastaneRandevuOtomasyonu.Properties.Resources.cikis;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCikis.Location = new System.Drawing.Point(778, 11);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(32, 31);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmDoktorListele
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoktorListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoktorListele";
            this.Load += new System.EventHandler(this.frmDoktorListele_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cbxDoktorListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxBransListe;
        private System.Windows.Forms.ColumnHeader clmRandevuSayisi;
        private System.Windows.Forms.ColumnHeader clmDeneyim;
        private System.Windows.Forms.ColumnHeader clmDoktor;
        private System.Windows.Forms.ListView lwRandevuListesi;
        private System.Windows.Forms.ColumnHeader clmBrans;
        private System.Windows.Forms.Button btnRandevuListeleForm;
        private System.Windows.Forms.Button btRandevuAlForm;
        private System.Windows.Forms.Button btnDoktorEkleForm;
        private System.Windows.Forms.Button btnBransEkleForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuDon;
        private System.Windows.Forms.Button btnCikis;
    }
}