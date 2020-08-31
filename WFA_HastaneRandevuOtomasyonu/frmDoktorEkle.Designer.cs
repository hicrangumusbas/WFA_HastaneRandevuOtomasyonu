namespace WFA_HastaneRandevuOtomasyonu
{
    partial class frmDoktorEkle
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
            this.gbxDoktorEkle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.cbxDoktrBrans = new System.Windows.Forms.ComboBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBransEkleForm = new System.Windows.Forms.Button();
            this.btnDoktorlarıListeleForm = new System.Windows.Forms.Button();
            this.gbxDoktorEkle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDoktorEkle
            // 
            this.gbxDoktorEkle.BackColor = System.Drawing.Color.Transparent;
            this.gbxDoktorEkle.Controls.Add(this.label1);
            this.gbxDoktorEkle.Controls.Add(this.txtDoktorAdi);
            this.gbxDoktorEkle.Controls.Add(this.cbxDoktrBrans);
            this.gbxDoktorEkle.Controls.Add(this.btnDoktorEkle);
            this.gbxDoktorEkle.Controls.Add(this.label2);
            this.gbxDoktorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDoktorEkle.Location = new System.Drawing.Point(12, 52);
            this.gbxDoktorEkle.Margin = new System.Windows.Forms.Padding(15, 30, 30, 15);
            this.gbxDoktorEkle.Name = "gbxDoktorEkle";
            this.gbxDoktorEkle.Size = new System.Drawing.Size(470, 194);
            this.gbxDoktorEkle.TabIndex = 7;
            this.gbxDoktorEkle.TabStop = false;
            this.gbxDoktorEkle.Text = "Doktor Ekle";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Doktor Adı  :";
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAdi.Location = new System.Drawing.Point(118, 76);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(331, 26);
            this.txtDoktorAdi.TabIndex = 26;
            // 
            // cbxDoktrBrans
            // 
            this.cbxDoktrBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoktrBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDoktrBrans.FormattingEnabled = true;
            this.cbxDoktrBrans.Location = new System.Drawing.Point(118, 44);
            this.cbxDoktrBrans.Name = "cbxDoktrBrans";
            this.cbxDoktrBrans.Size = new System.Drawing.Size(331, 26);
            this.cbxDoktrBrans.TabIndex = 25;
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.Color.Black;
            this.btnDoktorEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorEkle.Location = new System.Drawing.Point(118, 132);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(331, 41);
            this.btnDoktorEkle.TabIndex = 5;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branşı        :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoktorlarıListeleForm);
            this.groupBox1.Controls.Add(this.btnMenuDon);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnBransEkleForm);
            this.groupBox1.Location = new System.Drawing.Point(13, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 48);
            this.groupBox1.TabIndex = 8;
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
            this.btnMenuDon.Location = new System.Drawing.Point(394, 11);
            this.btnMenuDon.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnMenuDon.Name = "btnMenuDon";
            this.btnMenuDon.Size = new System.Drawing.Size(32, 31);
            this.btnMenuDon.TabIndex = 33;
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
            this.btnCikis.Location = new System.Drawing.Point(432, 11);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(32, 31);
            this.btnCikis.TabIndex = 32;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            this.btnBransEkleForm.TabIndex = 27;
            this.btnBransEkleForm.Text = "Brans Ekle";
            this.btnBransEkleForm.UseVisualStyleBackColor = false;
            this.btnBransEkleForm.Click += new System.EventHandler(this.btnBransEkleForm_Click);
            // 
            // btnDoktorlarıListeleForm
            // 
            this.btnDoktorlarıListeleForm.BackColor = System.Drawing.Color.Black;
            this.btnDoktorlarıListeleForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorlarıListeleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorlarıListeleForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoktorlarıListeleForm.Location = new System.Drawing.Point(124, 13);
            this.btnDoktorlarıListeleForm.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnDoktorlarıListeleForm.Name = "btnDoktorlarıListeleForm";
            this.btnDoktorlarıListeleForm.Size = new System.Drawing.Size(169, 27);
            this.btnDoktorlarıListeleForm.TabIndex = 34;
            this.btnDoktorlarıListeleForm.Text = "Doktorları Listele";
            this.btnDoktorlarıListeleForm.UseVisualStyleBackColor = false;
            this.btnDoktorlarıListeleForm.Click += new System.EventHandler(this.btnDoktorlarıListeleForm_Click);
            // 
            // frmDoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(494, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDoktorEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoktorEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoktorEkle";
            this.Load += new System.EventHandler(this.frmDoktorEkle_Load);
            this.gbxDoktorEkle.ResumeLayout(false);
            this.gbxDoktorEkle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDoktorEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBransEkleForm;
        public System.Windows.Forms.ComboBox cbxDoktrBrans;
        private System.Windows.Forms.Button btnDoktorlarıListeleForm;
    }
}