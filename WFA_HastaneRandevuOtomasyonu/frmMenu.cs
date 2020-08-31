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

        //Sayfalara Geçiş
        frmLogin LoginForm;
        frmBransEkle BransEkleForm;
        frmDoktorEkle DoktorEkleForm;
        frmRandevuEkle RandevuEkleForm;
        frmRandevuListele RandevuListeleForm;
        private void pbxBrans_Click(object sender, EventArgs e)
        {
            BransEkleForm = new frmBransEkle();
            BransEkleForm.Show();
            this.Hide();

        }
        private void pbxDoktor_Click(object sender, EventArgs e)
        {
            DoktorEkleForm = new frmDoktorEkle();
            DoktorEkleForm.Show();
            this.Hide();
        }
        private void pbxRandevu_Click(object sender, EventArgs e)
        {
            RandevuEkleForm = new frmRandevuEkle();
            RandevuEkleForm.Show();
            this.Hide();
        }
        private void pbxRandevuListesi_Click(object sender, EventArgs e)
        {
            RandevuListeleForm = new frmRandevuListele();
            RandevuListeleForm.Show();
            this.Hide();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginForm = new frmLogin();
            LoginForm.Show();
            this.Hide();
        }
        public static void Temizle(Form frm)
        {
            foreach (Control ctr in frm.Controls)
            {
                if (ctr is GroupBox)
                {
                    GroupBox gbx = (GroupBox)ctr;
                    foreach (Control control in gbx.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox txt = (TextBox)control;
                            txt.Clear();
                        }
                        if (control is ComboBox)
                        {
                            ComboBox cbx = (ComboBox)control;
                            cbx.SelectedIndex = -1;
                        }
                        else if (control is DateTimePicker)
                        {
                            DateTimePicker dtp = (DateTimePicker)control;
                            dtp.Value = DateTime.Now;
                        }

                    }
                }
                else if (ctr is TextBox)
                {
                    TextBox txt = (TextBox)ctr;
                    txt.Clear();
                }
                else if (ctr is ComboBox)
                {
                    ComboBox cbx = (ComboBox)ctr;
                    cbx.SelectedIndex = -1;
                }
                else if (ctr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctr;
                    dtp.Value = DateTime.Now;
                }
                else if (ctr is ListView)
                {
                    ListView lw = (ListView)ctr;
                    lw.Items.Clear();
                }
            }
        }
    }
}
