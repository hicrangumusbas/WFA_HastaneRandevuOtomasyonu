namespace WFA_HastaneRandevuOtomasyonu
{
    partial class frmRandevuEkle
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
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxDoktorSecim = new System.Windows.Forms.ComboBox();
            this.cbxBransSecim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbtn12_00 = new System.Windows.Forms.Button();
            this.btnbtn11_30 = new System.Windows.Forms.Button();
            this.btnbtn11_00 = new System.Windows.Forms.Button();
            this.btn10_30 = new System.Windows.Forms.Button();
            this.btn10_00 = new System.Windows.Forms.Button();
            this.btn09_30 = new System.Windows.Forms.Button();
            this.btn09_00 = new System.Windows.Forms.Button();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btRandevuListele = new System.Windows.Forms.Button();
            this.gbxRandevuEkle = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.gbxRandevuEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(146, 196);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(331, 26);
            this.dtpRandevuTarihi.TabIndex = 5;
            this.dtpRandevuTarihi.Validating += new System.ComponentModel.CancelEventHandler(this.dtpRandevuTarihi_Validating);
            // 
            // cbxDoktorSecim
            // 
            this.cbxDoktorSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoktorSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDoktorSecim.FormattingEnabled = true;
            this.cbxDoktorSecim.Location = new System.Drawing.Point(146, 164);
            this.cbxDoktorSecim.Name = "cbxDoktorSecim";
            this.cbxDoktorSecim.Size = new System.Drawing.Size(331, 26);
            this.cbxDoktorSecim.TabIndex = 4;
            // 
            // cbxBransSecim
            // 
            this.cbxBransSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBransSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBransSecim.FormattingEnabled = true;
            this.cbxBransSecim.Location = new System.Drawing.Point(146, 132);
            this.cbxBransSecim.Name = "cbxBransSecim";
            this.cbxBransSecim.Size = new System.Drawing.Size(331, 26);
            this.cbxBransSecim.TabIndex = 3;
            this.cbxBransSecim.SelectedIndexChanged += new System.EventHandler(this.cbxBransSecim_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Randevu Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Doktor Seçin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Branş Seçin";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(146, 99);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(331, 26);
            this.txtSoyadi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyadı :";
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(146, 67);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(331, 26);
            this.txtAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adı :";
            // 
            // btnbtn12_00
            // 
            this.btnbtn12_00.BackColor = System.Drawing.Color.Black;
            this.btnbtn12_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbtn12_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbtn12_00.ForeColor = System.Drawing.SystemColors.Control;
            this.btnbtn12_00.Location = new System.Drawing.Point(683, 245);
            this.btnbtn12_00.Name = "btnbtn12_00";
            this.btnbtn12_00.Size = new System.Drawing.Size(101, 41);
            this.btnbtn12_00.TabIndex = 11;
            this.btnbtn12_00.Text = "12:00";
            this.btnbtn12_00.UseVisualStyleBackColor = false;
            this.btnbtn12_00.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btnbtn11_30
            // 
            this.btnbtn11_30.BackColor = System.Drawing.Color.Black;
            this.btnbtn11_30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbtn11_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbtn11_30.ForeColor = System.Drawing.SystemColors.Control;
            this.btnbtn11_30.Location = new System.Drawing.Point(576, 245);
            this.btnbtn11_30.Name = "btnbtn11_30";
            this.btnbtn11_30.Size = new System.Drawing.Size(101, 41);
            this.btnbtn11_30.TabIndex = 11;
            this.btnbtn11_30.Text = "11:30";
            this.btnbtn11_30.UseVisualStyleBackColor = false;
            this.btnbtn11_30.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btnbtn11_00
            // 
            this.btnbtn11_00.BackColor = System.Drawing.Color.Black;
            this.btnbtn11_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbtn11_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbtn11_00.ForeColor = System.Drawing.SystemColors.Control;
            this.btnbtn11_00.Location = new System.Drawing.Point(469, 245);
            this.btnbtn11_00.Name = "btnbtn11_00";
            this.btnbtn11_00.Size = new System.Drawing.Size(101, 41);
            this.btnbtn11_00.TabIndex = 10;
            this.btnbtn11_00.Text = "11:00";
            this.btnbtn11_00.UseVisualStyleBackColor = false;
            this.btnbtn11_00.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btn10_30
            // 
            this.btn10_30.BackColor = System.Drawing.Color.Black;
            this.btn10_30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10_30.ForeColor = System.Drawing.SystemColors.Control;
            this.btn10_30.Location = new System.Drawing.Point(362, 245);
            this.btn10_30.Name = "btn10_30";
            this.btn10_30.Size = new System.Drawing.Size(101, 41);
            this.btn10_30.TabIndex = 9;
            this.btn10_30.Text = "10:30";
            this.btn10_30.UseVisualStyleBackColor = false;
            this.btn10_30.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btn10_00
            // 
            this.btn10_00.BackColor = System.Drawing.Color.Black;
            this.btn10_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10_00.ForeColor = System.Drawing.SystemColors.Control;
            this.btn10_00.Location = new System.Drawing.Point(255, 245);
            this.btn10_00.Name = "btn10_00";
            this.btn10_00.Size = new System.Drawing.Size(101, 41);
            this.btn10_00.TabIndex = 8;
            this.btn10_00.Text = "10:00";
            this.btn10_00.UseVisualStyleBackColor = false;
            this.btn10_00.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btn09_30
            // 
            this.btn09_30.BackColor = System.Drawing.Color.Black;
            this.btn09_30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn09_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn09_30.ForeColor = System.Drawing.SystemColors.Control;
            this.btn09_30.Location = new System.Drawing.Point(148, 245);
            this.btn09_30.Name = "btn09_30";
            this.btn09_30.Size = new System.Drawing.Size(101, 41);
            this.btn09_30.TabIndex = 7;
            this.btn09_30.Text = "09:30";
            this.btn09_30.UseVisualStyleBackColor = false;
            this.btn09_30.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // btn09_00
            // 
            this.btn09_00.BackColor = System.Drawing.Color.Black;
            this.btn09_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn09_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn09_00.ForeColor = System.Drawing.SystemColors.Control;
            this.btn09_00.Location = new System.Drawing.Point(41, 245);
            this.btn09_00.Name = "btn09_00";
            this.btn09_00.Size = new System.Drawing.Size(101, 41);
            this.btn09_00.TabIndex = 6;
            this.btn09_00.Text = "09:00";
            this.btn09_00.UseVisualStyleBackColor = false;
            this.btn09_00.Click += new System.EventHandler(this.SaatSecimi_Click);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(146, 35);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(331, 26);
            this.txtTCNo.TabIndex = 0;
            this.txtTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik No :";
            // 
            // btRandevuListele
            // 
            this.btRandevuListele.BackColor = System.Drawing.Color.Black;
            this.btRandevuListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRandevuListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRandevuListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btRandevuListele.Location = new System.Drawing.Point(13, 13);
            this.btRandevuListele.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btRandevuListele.Name = "btRandevuListele";
            this.btRandevuListele.Size = new System.Drawing.Size(169, 27);
            this.btRandevuListele.TabIndex = 29;
            this.btRandevuListele.Text = "Randevuları Listele";
            this.btRandevuListele.UseVisualStyleBackColor = false;
            this.btRandevuListele.Click += new System.EventHandler(this.btRandevuListele_Click);
            // 
            // gbxRandevuEkle
            // 
            this.gbxRandevuEkle.BackColor = System.Drawing.Color.Transparent;
            this.gbxRandevuEkle.Controls.Add(this.dtpRandevuTarihi);
            this.gbxRandevuEkle.Controls.Add(this.cbxDoktorSecim);
            this.gbxRandevuEkle.Controls.Add(this.cbxBransSecim);
            this.gbxRandevuEkle.Controls.Add(this.label8);
            this.gbxRandevuEkle.Controls.Add(this.label7);
            this.gbxRandevuEkle.Controls.Add(this.label6);
            this.gbxRandevuEkle.Controls.Add(this.txtSoyadi);
            this.gbxRandevuEkle.Controls.Add(this.label5);
            this.gbxRandevuEkle.Controls.Add(this.txtAdi);
            this.gbxRandevuEkle.Controls.Add(this.label4);
            this.gbxRandevuEkle.Controls.Add(this.btnbtn12_00);
            this.gbxRandevuEkle.Controls.Add(this.btnbtn11_30);
            this.gbxRandevuEkle.Controls.Add(this.btnbtn11_00);
            this.gbxRandevuEkle.Controls.Add(this.btn10_30);
            this.gbxRandevuEkle.Controls.Add(this.btn10_00);
            this.gbxRandevuEkle.Controls.Add(this.btn09_30);
            this.gbxRandevuEkle.Controls.Add(this.btn09_00);
            this.gbxRandevuEkle.Controls.Add(this.txtTCNo);
            this.gbxRandevuEkle.Controls.Add(this.label3);
            this.gbxRandevuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRandevuEkle.Location = new System.Drawing.Point(11, 53);
            this.gbxRandevuEkle.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.gbxRandevuEkle.Name = "gbxRandevuEkle";
            this.gbxRandevuEkle.Size = new System.Drawing.Size(816, 292);
            this.gbxRandevuEkle.TabIndex = 10;
            this.gbxRandevuEkle.TabStop = false;
            this.gbxRandevuEkle.Text = "Randevu Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuDon);
            this.groupBox1.Controls.Add(this.btRandevuListele);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 48);
            this.groupBox1.TabIndex = 9;
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
            this.btnMenuDon.TabIndex = 35;
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
            this.btnCikis.TabIndex = 34;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(839, 350);
            this.Controls.Add(this.gbxRandevuEkle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRandevuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRandevuEkle";
            this.Load += new System.EventHandler(this.frmRandevuEkle_Load);
            this.gbxRandevuEkle.ResumeLayout(false);
            this.gbxRandevuEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnbtn12_00;
        private System.Windows.Forms.Button btnbtn11_30;
        private System.Windows.Forms.Button btnbtn11_00;
        private System.Windows.Forms.Button btn10_30;
        private System.Windows.Forms.Button btn10_00;
        private System.Windows.Forms.Button btn09_30;
        private System.Windows.Forms.Button btn09_00;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRandevuListele;
        private System.Windows.Forms.GroupBox gbxRandevuEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuDon;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.ComboBox cbxDoktorSecim;
        public System.Windows.Forms.ComboBox cbxBransSecim;
    }
}