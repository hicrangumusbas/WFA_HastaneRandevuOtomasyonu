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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public static string kullaniciRolu;
        public static frmLogin LoginForm = new frmLogin();

        private void frmMenu_Load(object sender, EventArgs e)
        {
            switch (kullaniciRolu)
            {
                case "Admin":
                    frmMenu.kullaniciRolu = "Admin";
                    pbxBrans.Visible = true;
                    pbxDoktor.Visible = true;
                    pbxRandevu.Visible = true;
                    pbxRandevuListesi.Visible = true;
                    break;
                case "Member":
                    frmMenu.kullaniciRolu = "Member";
                    pbxBrans.Visible = false;
                    pbxDoktor.Visible = false;
                    pbxRandevu.Visible = true;
                    pbxRandevuListesi.Visible = false;

                    break;
                case "Moderator":
                    frmMenu.kullaniciRolu = "Moderator";
                    pbxBrans.Visible = false;
                    pbxDoktor.Visible = false;
                    pbxRandevu.Visible = true;
                    pbxRandevuListesi.Visible = true;

                    break;
                default:
                    break;

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            lblKullaniciAdi.Text = "";
            this.Hide();
        }
    }
}
