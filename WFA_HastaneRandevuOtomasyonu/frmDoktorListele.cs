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
    public partial class frmDoktorListele : Form
    {
        public frmDoktorListele()
        {
            InitializeComponent();
        }
        private void frmDoktorListele_Load(object sender, EventArgs e)
        {
            foreach (BransClass _bransListesi in BransClass.BransListe)
            {
                cbxBransListe.Items.Add(_bransListesi.Ad);
            }
            DoktorListele();
        }

        private void cbxBransListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoktorListe.SelectedIndex = -1;
            cbxDoktorListe.Items.Clear();

            foreach (BransClass _bransListesi in BransClass.BransListe)
            {
                if (_bransListesi.Ad == (string)cbxBransListe.SelectedItem)
                {
                    foreach (DoktorClass _doktorListesi in _bransListesi.DoktorListe)
                    {
                        cbxDoktorListe.Items.Add(_doktorListesi.Ad);
                    }
                }
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cbxBransListe.SelectedIndex != -1)
            {
                if (cbxDoktorListe.SelectedIndex != -1)
                {
                    DoktorListele((string)cbxBransListe.SelectedItem, (string)cbxDoktorListe.SelectedItem);
                }
                else
                {
                    DoktorListele((string)cbxBransListe.SelectedItem);
                }
            }
            else
            {
                DoktorListele();
            }
        }
        public void DoktorListele()
        {
            lwRandevuListesi.Items.Clear();
            foreach (BransClass _bransListe in BransClass.BransListe)
            {
                foreach (DoktorClass _doktorListe in _bransListe.DoktorListe)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = _bransListe.Ad;
                    lvi.SubItems.Add(_doktorListe.Ad);
                    lvi.SubItems.Add(_doktorListe.DeneyimYili.ToString());
                    lvi.SubItems.Add(_doktorListe.RandevuSayisi.ToString());
                    lwRandevuListesi.Items.Add(lvi);
                }
            }
        }
        public void DoktorListele(string _bransAdi)
        {
            lwRandevuListesi.Items.Clear();
            foreach (BransClass _bransListe in BransClass.BransListe)
            {
                if (_bransListe.Ad == _bransAdi)
                {
                    foreach (DoktorClass _doktorListe in _bransListe.DoktorListe)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = _bransListe.Ad;
                        lvi.SubItems.Add(_doktorListe.Ad);
                        lvi.SubItems.Add(_doktorListe.DeneyimYili.ToString());
                        lvi.SubItems.Add(_doktorListe.RandevuSayisi.ToString());
                        lwRandevuListesi.Items.Add(lvi);
                    }
                }
            }
        }
        public void DoktorListele(string _bransAdi, string _doktorAdi)
        {
            lwRandevuListesi.Items.Clear();
            foreach (BransClass _bransListe in BransClass.BransListe)
            {
                foreach (DoktorClass _doktorListe in _bransListe.DoktorListe)
                {
                    if (_bransListe.Ad == _bransAdi && _doktorListe.Ad == _doktorAdi)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = _bransListe.Ad;
                        lvi.SubItems.Add(_doktorListe.Ad);
                        lvi.SubItems.Add(_doktorListe.DeneyimYili.ToString());
                        lvi.SubItems.Add(_doktorListe.RandevuSayisi.ToString());
                        lwRandevuListesi.Items.Add(lvi);
                        break;
                    }
                }
            }
        }

        //Sayfalara Geçiş
        frmLogin LoginForm;
        frmBransEkle BransEkleForm;
        frmDoktorEkle DoktorEkleForm;
        frmRandevuEkle RandevuAlForm;
        frmRandevuListele RandevuListeleForm;
        frmMenu MenuForm;

        private void btnBransEkleForm_Click(object sender, EventArgs e)
        {
            BransEkleForm = new frmBransEkle();
            BransEkleForm.Show();
            this.Hide();
        }
        private void btnDoktorEkleForm_Click(object sender, EventArgs e)
        {
            DoktorEkleForm = new frmDoktorEkle();
            DoktorEkleForm.Show();
            this.Hide();
        }
        private void btRandevuAlForm_Click(object sender, EventArgs e)
        {
            RandevuAlForm = new frmRandevuEkle();
            RandevuAlForm.Show();
            this.Hide();
        }
        private void btRandevuListeleForm_Click(object sender, EventArgs e)
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
