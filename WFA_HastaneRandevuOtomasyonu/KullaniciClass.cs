using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevuOtomasyonu
{
    public class KullaniciClass : Base
    {
        public KullaniciClass()
        {
        }

        public string Parolasi { get; set; }
        public Rolu Rolu { get; set; }
        public DateTime SonOturumTarihi { get; set; }

        public static List<KullaniciClass> KullaniciLog = new List<KullaniciClass>();
        private KullaniciClass kullanici;
        public void KullaniciEkle()
        {
            kullanici = new KullaniciClass()
            {
                Ad = "hicrangumusbas",
                Parolasi = "963",
                Rolu = Rolu.Admin
            };
            KullaniciLog.Add(kullanici);
            
            kullanici = new KullaniciClass()
            {
                Ad = "muratsahar",
                Parolasi = "1",
                Rolu = Rolu.Member
            };
            KullaniciLog.Add(kullanici);
           
            kullanici = new KullaniciClass()
            {
                Ad = "ugurcanyuksel",
                Parolasi = "2",
                Rolu = Rolu.Moderator
            };
            KullaniciLog.Add(kullanici);

        }
    }

}
