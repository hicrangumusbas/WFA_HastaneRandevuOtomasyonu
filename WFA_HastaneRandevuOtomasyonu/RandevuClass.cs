using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevuOtomasyonu
{
    public class RandevuClass
    {
        public RandevuClass()
        {
        }

        public HastaClass HastaBilgileri { get; set; }
        public BransClass BransBilgisi { get; set; }
        public DoktorClass DoktorBilgisi { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public DateTime RandevuSaati { get; set; }
        public static List<RandevuClass> RandevuListesi = new List<RandevuClass>();
       
        RandevuClass _randevu;
        public string RandevuEkle(HastaClass _hastaBilgisi, BransClass _bransBilgisi, DoktorClass _doktorBilgisi, DateTime zaman)
        {
            HastaClass.HastaListe.Add(_hastaBilgisi);

            _randevu = new RandevuClass();
            _randevu.HastaBilgileri = _hastaBilgisi;
            _randevu.BransBilgisi = _bransBilgisi;
            _randevu.DoktorBilgisi = _doktorBilgisi;
            _randevu.RandevuTarihi = zaman;
            RandevuListesi.Add(_randevu);
            return $"{_hastaBilgisi.Ad} {_hastaBilgisi.Soyad} \nRandevunuz başarıyla oluşturuldu";
        }
    }
}
