using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTODetay
    {
        public int islemNo { get; set; }
        public int gonderenMusteri { get; set; }
        public int gonderilenMusteri { get; set; }
        public int gonderenHesap { get; set; }
        public int gonderilenHesap { get; set; }
        public decimal miktar { get; set; }
        public string bilgi { get; set; }
        public  DateTime tarih { get; set; }

        public DTODetay(int islemNo, int gonderenMusteri, int gonderilenMusteri, int gonderenHesap, int gonderilenHesap, decimal miktar, string bilgi, DateTime tarih)
        {
            this.islemNo = islemNo;
            this.gonderenMusteri = gonderenMusteri;
            this.gonderilenMusteri = gonderilenMusteri;
            this.gonderenHesap = gonderenHesap;
            this.gonderilenHesap = gonderilenHesap;
            this.miktar = miktar;
            this.bilgi = bilgi;
            this.tarih = tarih;
        }
    }
}
