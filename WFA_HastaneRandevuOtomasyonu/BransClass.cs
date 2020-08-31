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
        public static List<string> bransIsimleri = new List<string>();
        public string BransEkle(string _brans)
        {
            string msj;
            if (bransIsimleri.Contains(_brans))
            {
                msj = $"{_brans} Branşı sistemde zaten mevcut! ";
            }
            else
            {
                BransClass _bransEkle = new BransClass();
                _bransEkle.Ad = _brans;
                BransListe.Add(_bransEkle);

                bransIsimleri.Add(_brans);
                
                msj = $"{_brans} Branşı sisteme başarıyla eklendi. ";
            }
            return msj;

        }

        public string DoktorEkle(DoktorClass doktorBilgisi, string bransAdi)
        {
            if (BransListe.Count > 0)
            {
                if (bransIsimleri.Contains(bransAdi))
                {
                    foreach (BransClass bransListe in BransListe)
                    {
                        if (bransListe.Ad == bransAdi)
                        {
                            bransListe.DoktorListe.Add(doktorBilgisi);
                            break;
                        }
                    }
                }
            }
            return $"{bransAdi} için Dr {doktorBilgisi.Ad} sisteme başarıyla eklendi. ";
        }
        public string DoktorRandevuSayisiEkle(DoktorClass doktorBilgisi, string bransAdi)
        {
            if (BransListe.Count > 0)
            {
                if (bransIsimleri.Contains(bransAdi))
                {
                    foreach (BransClass _bransListe in BransListe)
                    {
                        if (_bransListe.Ad == bransAdi)
                        {
                            foreach (DoktorClass _doktorListe in _bransListe.DoktorListe)
                            {
                                if(_doktorListe.Ad==doktorBilgisi.Ad)
                                {
                                    doktorBilgisi.RandevuSayisi++;
                                }
                            }
                        }
                    }
                }
            }
            return $"{bransAdi} için Dr {doktorBilgisi.Ad} sisteme başarıyla eklendi. ";
        }
    }
}
