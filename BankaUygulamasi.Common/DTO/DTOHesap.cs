using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOHesap
    {
        public int musteriNo { get; set; }
        public int hesapNo { get; set; }
        public string dovizCinsi { get; set; }
        public decimal bakiye { get; set; }
        public bool durumKodu { get; set; }

        public DTOHesap(int musteriNo, int hesapNo, string dovizCinsi, decimal bakiye, bool durumKodu)
        {
            this.musteriNo = musteriNo;
            this.hesapNo = hesapNo;
            this.dovizCinsi = dovizCinsi;
            this.bakiye = bakiye;
            this.durumKodu = durumKodu;
        }
    }
}
