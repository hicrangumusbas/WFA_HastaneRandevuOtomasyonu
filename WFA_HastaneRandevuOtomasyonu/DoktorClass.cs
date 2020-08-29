using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRandevuOtomasyonu
{
    public class DoktorClass : Base
    {
        public override string ToString()
        {
            return Ad;

        }
        public int Deneyim { get; set; }
    }
}
