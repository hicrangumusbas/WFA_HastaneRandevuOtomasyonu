using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFA_HastaneRandevuOtomasyonu
{
    public partial class frmBransEkle : Form
    {
        public frmBransEkle()
        {
            InitializeComponent();
        }
        BransClass _bransClass = new BransClass();
        frmDoktorEkle _frmDoktorEkle = new frmDoktorEkle();
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            if (txtBransAdi.Text != null && txtBransAdi.Text != "")
            {
                string msj = _bransClass.BransEkle(txtBransAdi.Text);

                DialogResult dr = MessageBox.Show($"{msj}\n {txtBransAdi.Text} için sisteme doktar kaydı yapacak mısınız?", "Doktor Ekle", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    _frmDoktorEkle.Show();
                    //BransClass.bransIsimleri.IndexOf(txtBransAdi.Text);
                    _frmDoktorEkle.cbxDoktrBrans.SelectedIndex = _frmDoktorEkle.cbxDoktrBrans.FindString(txtBransAdi.Text);
                    this.Hide();
                }

                frmMenu.Temizle(this);
            }
            else
            {
                MessageBox.Show("Zorunlu alanları boş geçemezsiniz");
            }
        }

        //Sayfalara Geçiş
        frmLogin LoginForm ;
        frmDoktorEkle DoktorEkleForm;
        frmMenu MenuForm;
        private void btnDoktorEkleForm_Click(object sender, EventArgs e)
        {
            DoktorEkleForm = new frmDoktorEkle();
            DoktorEkleForm.Show();
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
