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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        KullaniciClass kullanici = new KullaniciClass();
        public static frmMenu frmMenu = new frmMenu();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            kullanici.KullaniciEkle();
        }

        string kullaniciAdi,parola;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAd.Text;
            parola = txtKullaniciParola.Text;

            foreach (KullaniciClass kullaniciKontrol in KullaniciClass.KullaniciLog)
            {
                if (kullaniciAdi == kullaniciKontrol.Ad && parola == kullaniciKontrol.Parolasi)
                {
                    frmMenu.lblKullaniciAdi.Text = kullaniciAdi;
                    switch (kullaniciKontrol.Rolu)
                    {
                        case Rolu.Admin:
                            frmMenu.kullaniciRolu = "Admin";
                            frmMenu.Show();
                            this.Hide();
                            break;
                        case Rolu.Member:
                            frmMenu.kullaniciRolu = "Member";
                            frmMenu.Show();
                            this.Hide();
                            break;
                        case Rolu.Moderator:
                            frmMenu.kullaniciRolu = "Moderator";
                            frmMenu.Show();
                            this.Hide();
                            break;
                        default:
                            break;

                    }
                }

            }
        }
    }
}
