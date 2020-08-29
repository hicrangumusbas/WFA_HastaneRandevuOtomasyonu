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

    }
}
