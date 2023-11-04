using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOMusteri
    {
        public int musteriNo { get; set; }
        public string tckn { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string baba_ad { get; set; }
        public string dogum_tarihi { get; set; }
        public string cinsiyet { get; set; }
        public string kayitli_il { get; set; }
        public string kayitli_ilce { get; set; }

        public DTOMusteri(int musteriNo, string tckn, string ad, string soyad, string baba_ad, string dogum_tarihi, string cinsiyet, string kayitli_il, string kayitli_ilce)
        {
            this.musteriNo = musteriNo;
            this.tckn = tckn;
            this.ad = ad;
            this.soyad = soyad;
            this.baba_ad = baba_ad;
            this.dogum_tarihi = dogum_tarihi;
            this.cinsiyet = cinsiyet;
            this.kayitli_il = kayitli_il;
            this.kayitli_ilce = kayitli_ilce;
        }
    }
}
