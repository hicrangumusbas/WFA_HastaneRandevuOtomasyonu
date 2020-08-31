using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRandevuOtomasyonu
{
    public partial class frmRandevuEkle : Form
    {
        public frmRandevuEkle()
        {
            InitializeComponent();
        }
        DateTime zaman = DateTime.Now;
        string duzenlenenZaman;
        private void frmRandevuEkle_Load(object sender, EventArgs e)
        {
            foreach (BransClass _bransListesi in BransClass.BransListe)
            {
                cbxBransSecim.Items.Add(_bransListesi.Ad);
            }
        }

        private void cbxBransSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoktorSecim.SelectedIndex = -1;
            cbxDoktorSecim.Items.Clear();
            foreach (BransClass _bransListesi in BransClass.BransListe)
            {
                if (_bransListesi.Ad == (string)cbxBransSecim.SelectedItem)
                {
                    foreach (DoktorClass _doktorListesi in _bransListesi.DoktorListe)
                    {
                        cbxDoktorSecim.Items.Add(_doktorListesi.Ad);
                    }
                }
            }
        }
        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dtpRandevuTarihi_Validating(object sender, CancelEventArgs e)
        {
            zaman = dtpRandevuTarihi.Value;
        }
        private void SaatSecimi_Click(object sender, EventArgs e)
        {
            if (txtTCNo.Text.Count() > 0 && txtAdi.Text.Count() > 0 && txtSoyadi.Text.Count() > 0 && cbxBransSecim.SelectedIndex > -1 && cbxDoktorSecim.SelectedIndex > -1)
            {
                SaatKontrolu(sender);
            }
            else
            {
                MessageBox.Show("Hasta bilgilerini doldurduktan sonra seçim yapınız lütfen.");
            }
        }
        public void SaatKontrolu(object sender)
        {
            RandevuListeleForm = new frmRandevuListele();
            duzenlenenZaman = zaman.ToShortDateString();
            zaman = Convert.ToDateTime($"{duzenlenenZaman} {(sender as Button).Text}");

            if (DateTime.Compare(zaman, DateTime.Now) == 1 || DateTime.Compare(zaman, DateTime.Now) == 0)
            {
                string msj = RandevuEkle(zaman);
                (sender as Button).BackColor = Color.Tomato;
                DialogResult dr = MessageBox.Show($"{msj}\nRandevularınızı Görmek ister misiniz?", "Randevunuz başarıyla oluşturuldu", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    RandevuListeleForm.txtTCNo.Text = _hasta.TCNo;
                    RandevuListeleForm.Show();
                    this.Hide();
                }
                frmMenu.Temizle(this);
            }
            else if (DateTime.Compare(zaman, DateTime.Now) == -1)
            {
                MessageBox.Show("Geçerli bir tarih ve saat değeri giriniz");
                dtpRandevuTarihi.Value = DateTime.Now;
            }
        }

        HastaClass _hasta;
        BransClass _brans;
        DoktorClass _doktor;
        RandevuClass _randevu;
        public string RandevuEkle(DateTime zaman)
        {
            _hasta = new HastaClass();
            _hasta.TCNo = txtTCNo.Text;
            _hasta.Ad = txtAdi.Text;
            _hasta.Soyad = txtSoyadi.Text;

            _brans = new BransClass();
            _brans.Ad = (string)cbxBransSecim.SelectedItem;

            _doktor = new DoktorClass();
            _doktor.Ad = (string)cbxDoktorSecim.SelectedItem;
            _doktor.RandevuSayisi++;

            _randevu = new RandevuClass();
            _randevu.HastaBilgileri = _hasta;
            _randevu.BransBilgisi = _brans;
            _randevu.DoktorBilgisi = _doktor;

            _brans.DoktorRandevuSayisiEkle(_doktor, _brans.Ad);
            return _randevu.RandevuEkle(_hasta, _brans, _doktor, zaman);
        }

        //Sayfalara Geçiş
        frmLogin LoginForm;
        frmRandevuListele RandevuListeleForm;
        frmMenu MenuForm;
        private void btRandevuListele_Click(object sender, EventArgs e)
        {
            RandevuListeleForm = new frmRandevuListele();
            RandevuListeleForm.Show();
            this.Hide();
        }
        private void btnMenuDon_Click(object sender, EventArgs e)
        {
            MenuForm = new frmMenu();
            MenuForm.Show();
            this.Hide();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginForm = new frmLogin();
            LoginForm.Show();
            this.Hide();
        }


    }
}
