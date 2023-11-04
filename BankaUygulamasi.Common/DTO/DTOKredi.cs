using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOKredi
    {
        public int musteriNo { get; set; }
        public decimal krediMiktari { get; set; }
        public decimal aylikOdeme { get; set; }
        public int vade { get; set; }
        public int odenenTaksit { get; set; }
        public DateTime sonTarih { get; set; }

        public DTOKredi(int musteriNo, decimal krediMiktari, decimal aylikOdeme, int vade, int odenenTaksit, DateTime sonTarih)
        {
            this.musteriNo = musteriNo;
            this.krediMiktari = krediMiktari;
            this.aylikOdeme = aylikOdeme;
            this.vade = vade;
            this.odenenTaksit = odenenTaksit;
            this.sonTarih = sonTarih;
        }

        public DTOKredi(int musteriNo, decimal krediMiktari, int vade)
        {
            this.musteriNo = musteriNo;
            this.krediMiktari = krediMiktari;
            this.vade = vade;
        }
    }
}
