using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevuOtomasyonu
{
    public class BransClass : Base
    {
        public BransClass()
        {
            DoktorListe = new List<DoktorClass>();
        }

        public List<DoktorClass> DoktorListe { get; set; }
        public static List<BransClass> BransListe = new List<BransClass>();

        public override string ToString()
        {
            return Ad;

        }
    }
}
