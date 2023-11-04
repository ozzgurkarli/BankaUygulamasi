using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOFatura
    {
        public int musteriNo { get; set; }
        public int hesapNo { get; set; }
        public string faturaKodu { get; set; }
        public string faturaNo { get; set; }
        public decimal tutar { get; set; }
        public bool otomatikOdeme { get; set; }
        public DateTime sonOdemeTarihi { get; set; }
        public bool durumKodu { get; set; }

        public DTOFatura(int musteriNo, int hesapNo, string faturaKodu, string faturaNo, decimal tutar, bool otomatikOdeme, DateTime sonOdemeTarihi, bool durumKodu)
        {
            this.musteriNo = musteriNo;
            this.hesapNo = hesapNo;
            this.faturaKodu = faturaKodu;
            this.faturaNo = faturaNo;
            this.tutar = tutar;
            this.otomatikOdeme = otomatikOdeme;
            this.sonOdemeTarihi = sonOdemeTarihi;
            this.durumKodu = durumKodu;
        }
    }
}
