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
    public partial class frmRandevuListele : Form
    {
        public frmRandevuListele()
        {
            InitializeComponent();
        }

        private void frmRandevuListele_Load(object sender, EventArgs e)
        {
            RandevuListele(txtTCNo.Text);
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtTCNo.Text.Count() > 0)
            {
                RandevuListele(txtTCNo.Text);
            }
            else
            {
                RandevuListele();
            }
        }
        public void RandevuListele()
        {
            lwRandevuListesi.Items.Clear();
            foreach (RandevuClass randevu in RandevuClass.RandevuListesi)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = randevu.HastaBilgileri.TCNo;
                lvi.SubItems.Add(randevu.HastaBilgileri.Ad);
                lvi.SubItems.Add(randevu.HastaBilgileri.Soyad);
                lvi.SubItems.Add(randevu.BransBilgisi.Ad);
                lvi.SubItems.Add(randevu.DoktorBilgisi.Ad);
                lvi.SubItems.Add(randevu.RandevuTarihi.ToShortDateString());
                lvi.SubItems.Add(randevu.RandevuTarihi.ToShortTimeString());
                lwRandevuListesi.Items.Add(lvi);
            }
        }
        public void RandevuListele(string aranacakDeger)
        {
            lwRandevuListesi.Items.Clear();
            foreach (RandevuClass randevu in RandevuClass.RandevuListesi)
            {
                if (randevu.HastaBilgileri.TCNo == aranacakDeger)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = randevu.HastaBilgileri.TCNo;
                    lvi.SubItems.Add(randevu.HastaBilgileri.Ad);
                    lvi.SubItems.Add(randevu.HastaBilgileri.Soyad);
                    lvi.SubItems.Add(randevu.BransBilgisi.Ad);
                    lvi.SubItems.Add(randevu.DoktorBilgisi.Ad);
                    lvi.SubItems.Add(randevu.RandevuTarihi.ToShortDateString());
                    lvi.SubItems.Add(randevu.RandevuTarihi.ToShortTimeString());
                    lwRandevuListesi.Items.Add(lvi);
                }
            }
        }


       //Sayfalara Geçiş
        frmLogin LoginForm;
        frmRandevuEkle RandevuAlForm;
        frmMenu MenuForm;
        private void btRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAlForm = new frmRandevuEkle();
            RandevuAlForm.Show();
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
