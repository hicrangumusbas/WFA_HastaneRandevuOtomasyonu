using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevuOtomasyonu
{
    public class HastaClass : Base
    {
        public HastaClass()
        {
        }

        public string TCNo { get; set; }
        public string Soyad { get; set; }
        public static List<HastaClass> HastaListe = new List<HastaClass>();
    }
}
