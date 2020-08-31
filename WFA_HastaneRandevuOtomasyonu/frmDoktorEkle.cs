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
    public partial class frmDoktorEkle : Form
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {
            foreach (string bransIsmi in BransClass.bransIsimleri)
            {
                cbxDoktrBrans.Items.Add(bransIsmi);
            }

        }
        BransClass _bransClass;
        DoktorClass _doktorClass;
        frmRandevuEkle _frmRandevuEkle;

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            _bransClass = new BransClass();
            _doktorClass = new DoktorClass();
            _frmRandevuEkle = new frmRandevuEkle();

            _doktorClass.Ad = txtDoktorAdi.Text;

            if (cbxDoktrBrans.SelectedIndex > -1)
            {
                string msj = _bransClass.DoktorEkle(_doktorClass, (string)cbxDoktrBrans.SelectedItem);
                DialogResult dr = MessageBox.Show($"{msj}\n Dr {txtDoktorAdi.Text} için randevu kaydı yapacak mısınız?", "Randevu Al", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    _frmRandevuEkle.Show();
                    _frmRandevuEkle.cbxBransSecim.SelectedIndex = _frmRandevuEkle.cbxBransSecim.FindString((string)cbxDoktrBrans.SelectedItem);
                    _frmRandevuEkle.cbxDoktorSecim.SelectedIndex = _frmRandevuEkle.cbxDoktorSecim.FindString(txtDoktorAdi.Text);
                    this.Hide();

                }
                frmMenu.Temizle(this);
            }
            else
            {
                MessageBox.Show("Branş seçimi yapın lütfen!");
            }
        }

        //Sayfalara Geçiş
        frmLogin LoginForm;
        frmBransEkle BransEkleForm;
        frmDoktorListele DoktorListeleForm;
        frmMenu MenuForm;
        private void btnBransEkleForm_Click(object sender, EventArgs e)
        {
            BransEkleForm = new frmBransEkle();
            BransEkleForm.Show();
            this.Hide();

        }
        private void btnDoktorlarıListeleForm_Click(object sender, EventArgs e)
        {
            DoktorListeleForm = new frmDoktorListele();
            DoktorListeleForm.Show();
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
