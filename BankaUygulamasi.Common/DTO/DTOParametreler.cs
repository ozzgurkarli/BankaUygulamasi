using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOParametreler
    {
        public string grupKodu { get; set; }
        public string kod { get; set; }
        public string aciklama { get; set; }
        public string detay { get; set; }

        public DTOParametreler(string grupKodu, string kod, string aciklama, string detay)
        {
            this.grupKodu = grupKodu;
            this.kod = kod;
            this.aciklama = aciklama;
            this.detay = detay;
        }
    }
}
