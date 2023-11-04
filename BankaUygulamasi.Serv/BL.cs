using BankaUygulamasi.Common.DTO;
using BankaUygulamasi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaUygulamasi.Serv
{
    public class BL
    {
        Data.DAL db = new Data.DAL();
        DTOMusteri musteri;
        public BL() { }

        public bool AdminGirisKontrol(string tckn, string parola)
        {
            List<DTOGiris> kontrolList = db.AdminKontrolu(tckn, parola);

            if (kontrolList.Count > 0)
            {
                return true;
            }

            return false;
        }

        public DTOMusteri MusteriGirisKontrol(string tckn, string parola)
        {
            List<DTOGiris> kontrolList = db.MusteriKontrolu(tckn, parola);

            if (kontrolList.Count > 0)
            {
                musteri = db.DTOMusteriDoldur(tckn);

                return musteri;
            }

            return null;
        }

        public void FaturaOlustur()
        {
            int gecenGun = db.TarihFarkiniAl();

            while (gecenGun > 0)
            {
                db.FaturaOlustur(DateTime.Today.AddDays(-gecenGun));

                gecenGun--;

                db.TarihiGuncelle();
            }
        }

        public void OtomatikFaturaOde()
        {
            List<DTOFatura> list = db.FaturalariGetir();

            foreach (DTOFatura fatura in list)
            {
                if (DateTime.Today.Subtract(fatura.sonOdemeTarihi).Days >= 3 && fatura.otomatikOdeme && !fatura.durumKodu)
                {
                    db.HesapBakiyeGuncelle(fatura.hesapNo, -fatura.tutar);

                    db.FaturaDurumOdendi(fatura.faturaNo);
                }
            }
        }

        public void FaturaBilgisiKaydet(int musteri_no, int hesap_no, string fatura_kod, string abone_no, bool otomatik_odeme)
        {
            db.FaturaBilgisiKaydet(musteri_no, hesap_no, fatura_kod, abone_no, otomatik_odeme);
        }

        public void FaturaOdeElIle(string faturaNo)
        {
            List<DTOFatura> list = db.FaturalariGetir();
            DTOFatura fatura = null;

            foreach (DTOFatura fa in list)
            {
                if (fa.faturaNo == faturaNo && !fa.durumKodu)
                {
                    fatura = fa;
                    break;
                }
            }

            DTOHesap hesap = db.HesapDetayGetir(fatura.hesapNo);

            db.HesapBakiyeGuncelle(fatura.hesapNo, fatura.tutar);

            db.GecmisIslemlereGonder(hesap.musteriNo, 19999999, fatura.hesapNo, 19999999, fatura.tutar, "FATURA");

            db.FaturaDurumOdendi(fatura.faturaNo);

            MessageBox.Show("Fatura Ödendi.");
        }

        public DTODetay DetayEkraninaGonder(string islemNo)
        {
            List<DTOGecmisIslemler> list = db.GecmisIslemleriGetir();
            DTODetay detay;

            foreach (DTOGecmisIslemler islem in list)
            {
                if (islemNo == islem.islemNo.ToString())
                {
                    detay = new DTODetay(islem.islemNo, islem.gonderenMusteri, islem.gonderilenMusteri, islem.gonderenHesap, islem.gonderilenHesap, islem.miktar, islem.bilgi, islem.tarih);

                    return detay;
                }
            }

            return null;
        }

        public string[] GecmisIslemlerComboBox(int musteriNo)
        {
            List<DTOGecmisIslemler> islemler = db.GecmisIslemleriGetir();
            List<string> list = new List<string>();

            foreach (DTOGecmisIslemler islem in islemler)
            {
                if ((islem.bilgi != "GELEN" && islem.gonderenMusteri == musteriNo) || (islem.bilgi != "GIDEN" && islem.gonderilenMusteri == musteriNo))
                {
                    list.Add(islem.islemNo + "-İşlem No    " + islem.miktar + "-Miktar   " + islem.bilgi);
                }
            }

            string[] ll = new string[list.Count];

            int count = 0;

            foreach (string l in list)
            {
                ll[count] = l;
                count++;
            }

            return ll;
        }

        public string[] MusteriAktifHesaplarString(int musteriNo)
        {
            List<DTOHesap> listdb = db.HesaplariGetir();
            List<string> list = new List<string>();

            foreach (DTOHesap hsp in listdb)
            {
                if (hsp.musteriNo == musteriNo && hsp.durumKodu)
                {
                    list.Add($"{hsp.hesapNo}\t {hsp.bakiye} {hsp.dovizCinsi}");
                }
            }

            list.Sort();

            string[] ll = new string[list.Count];

            int count = 0;

            foreach (string l in list)
            {
                ll[count] = l;
                count++;
            }

            return ll;
        }

        public DTOMusteri MusteriGetirTCKNIle(string tckn)
        {
            DTOMusteri musteri = db.DTOMusteriDoldur(tckn);

            return musteri;
        }

        public DTOMusteri MusteriGetirMusteriNoIle(int musteriNo)
        {
            DTOMusteri musteri = db.DTOMusteriDoldurMusteriNoIle(musteriNo);

            return musteri;
        }

        public DTOMusteri MusteriOlustur(string tckn, string parola, string ad, string soyad, string baba_ad, string dogum_tarihi, string cinsiyet, string kayitli_il, string kayitli_ilce, DateTime kayit_tarihi)
        {
            db.MusteriOlustur(tckn, parola, ad, soyad, baba_ad, dogum_tarihi, cinsiyet, kayitli_il, kayitli_ilce, kayit_tarihi);

            return db.DTOMusteriDoldur(tckn);
        }

        public DTOMusteri MusteriGuncelle(string tckn, string ad, string soyad, string baba_ad, string dogum_tarihi, string cinsiyet, string kayitli_il, string kayitli_ilce, int musteri_no)
        {
            db.MusteriGuncelle(tckn, ad, soyad, baba_ad, dogum_tarihi, cinsiyet, kayitli_il, kayitli_ilce, musteri_no);

            return db.DTOMusteriDoldur(tckn);
        }

        public void ParolaDegistir(string tckn, string parola)
        {
            db.ParolaDegistir(tckn, parola);
        }

        public bool HesaplarArasiTransfer(int gonderenHesapNo, int gonderilenHesapNo, int miktar)
        {
            DTOHesap gonderenHesap = db.HesapDetayGetir(gonderenHesapNo);
            DTOHesap gonderilenHesap = db.HesapDetayGetir(gonderilenHesapNo);

            if (miktar > gonderenHesap.bakiye)
            {
                MessageBox.Show("Bakiye Yetersiz.");
            }

            else
            {
                decimal miktarDoviz = miktar * Convert.ToDecimal(Doviz.birim[gonderilenHesap.dovizCinsi]) / Convert.ToDecimal(Doviz.birim[gonderenHesap.dovizCinsi]);

                DialogResult dialogResult = MessageBox.Show($"{miktar} {gonderenHesap.dovizCinsi}->" +
                    $"{miktarDoviz.ToString("0.00").Replace(",", ".")} {gonderilenHesap.dovizCinsi} \nOnaylıyor musunuz?", "ONAY EKRANI", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    if (gonderenHesap.dovizCinsi.ToString() == gonderilenHesap.dovizCinsi.ToString())
                    {
                        db.HesapBakiyeGuncelle(gonderenHesap.hesapNo, -miktar);
                        db.HesapBakiyeGuncelle(gonderilenHesap.hesapNo, miktar);
                    }
                    else
                    {
                        db.HesapBakiyeGuncelle(gonderenHesap.hesapNo, -miktar);
                        db.HesapBakiyeGuncelle(gonderilenHesap.hesapNo, miktarDoviz);
                    }

                    MessageBox.Show("İşlem Başarılı.");

                    db.GecmisIslemlereGonder(gonderenHesap.musteriNo, gonderilenHesap.musteriNo, gonderenHesap.hesapNo, gonderilenHesap.hesapNo, miktar, "DOVIZ");

                    return true;
                }
            }
            return false;
        }

        public void HesapBakiyeGuncelle(int hesapNo, decimal miktar)
        {
            db.HesapBakiyeGuncelle(hesapNo, miktar);
        }

        public DTOHesap HesapDetayGetir(int hesapNo)
        {
            return db.HesapDetayGetir(hesapNo);
        }

        public void HesapOlustur(int musteriNo, string dovizCinsi)
        {
            db.HesapOlustur(musteriNo, dovizCinsi);
        }

        public string[] MusteriKredileriString(int musteriNo)
        {
            List<DTOKredi> list = db.KredileriGetir();

            foreach (DTOKredi kredi in list.ToList())
            {
                if (kredi.musteriNo != musteriNo)
                {
                    list.Remove(kredi);
                }
            }

            string[] ll = new string[list.Count];

            for (int i = 0; i < ll.Length; i++)
            {
                ll[i] = "KREDİ MİKTARI: " + list[i].krediMiktari;
            }

            return ll;

        }

        public DTOKredi MusteriKrediDetay(int musteriNo, decimal krediMiktari)
        {
            List<DTOKredi> list = db.KredileriGetir();

            foreach (DTOKredi kredi in list)
            {
                if (kredi.musteriNo == musteriNo && kredi.krediMiktari == krediMiktari)
                {
                    return kredi;
                }
            }

            return null;
        }

        public void KrediBasvuruGonder(int musteriNo, int tutar, int vade)
        {
            db.KrediBasvuruGonder(musteriNo, tutar, vade);
        }

        public void KrediKontrol()
        {
            int gunFarki;

            List<DTOKredi> listKredi = db.KredileriGetir();

            foreach (DTOKredi adm in listKredi)
            {
                if (adm.odenenTaksit >= adm.vade)
                {
                    db.BitenKrediyiSil(adm.musteriNo, adm.krediMiktari);
                }

                gunFarki = DateTime.Today.Subtract(adm.sonTarih).Days;

                while (gunFarki > 0)
                {
                    db.KrediBorcuOde(DateTime.Today, adm.musteriNo, adm.krediMiktari);

                    db.GecmisIslemlereGonder(adm.musteriNo, 19999999, 0, 19999999, adm.aylikOdeme, "KREDI");

                    List<DTOHesap> hesaplar = db.HesaplariGetir();

                    foreach (DTOHesap hesap in hesaplar)
                    {
                        if (hesap.musteriNo == adm.musteriNo && hesap.dovizCinsi == "TRY" && hesap.durumKodu)
                        {
                            db.HesapBakiyeGuncelle(hesap.hesapNo, -adm.aylikOdeme);

                            break;
                        }
                    }

                    gunFarki--;
                }
            }
        }

        public string[] IllerComboBox()
        {
            List<DTOParametreler> listdb = db.ParametreleriGetir();
            List<DTOParametreler> list = new List<DTOParametreler>();

            foreach (DTOParametreler parametre in listdb)
            {
                if (parametre.grupKodu == "IL")
                {
                    list.Add(parametre);
                }
            }

            string[] ll = new string[list.Count];

            for (int i = 0; i < ll.Length; i++)
            {
                ll[i] = list[i].aciklama;
            }

            return ll;
        }

        public string[] IlcelerComboBox(string ilKodu)
        {
            List<DTOParametreler> listdb = db.ParametreleriGetir();
            List<DTOParametreler> list = new List<DTOParametreler>();

            foreach (DTOParametreler parametre in listdb)
            {
                if (parametre.grupKodu == "ILCE" && parametre.detay == ilKodu)
                {
                    list.Add(parametre);
                }
            }

            string[] ll = new string[list.Count];

            for (int i = 0; i < ll.Length; i++)
            {
                ll[i] = list[i].aciklama;
            }

            return ll;
        }

        public string[] FaturalarComboBox()
        {
            List<DTOParametreler> listdb = db.ParametreleriGetir();
            List<DTOParametreler> list = new List<DTOParametreler>();

            foreach (DTOParametreler parametre in listdb)
            {
                if (parametre.grupKodu == "FATURA")
                {
                    list.Add(parametre);
                }
            }

            string[] ll = new string[list.Count];

            for (int i = 0; i < ll.Length; i++)
            {
                ll[i] = list[i].aciklama;
            }

            return ll;
        }

        public string IlGetir(string ilKodu)
        {
            List<DTOParametreler> list = db.ParametreleriGetir();

            foreach (DTOParametreler parametre in list)
            {
                if (parametre.grupKodu == "IL" && parametre.kod == ilKodu)
                {
                    return parametre.aciklama;
                }
            }

            return null;
        }

        public string IlceGetir(string ilceKodu)
        {
            List<DTOParametreler> list = db.ParametreleriGetir();

            foreach (DTOParametreler parametre in list)
            {
                if (parametre.grupKodu == "ILCE" && parametre.kod == ilceKodu)
                {
                    return parametre.aciklama;
                }
            }

            return null;
        }

        public string ParametreKodGetir(string aciklama)
        {
            List<DTOParametreler> list = db.ParametreleriGetir();

            foreach (DTOParametreler parametre in list)
            {
                if (parametre.aciklama == aciklama)
                {
                    return parametre.kod;
                }
            }

            return null;
        }

        public void BaskaHesabaTransfer(DTOHesap gonderenHesap, DTOHesap gonderilenHesap, decimal miktar)
        {
            HesapBakiyeGuncelle(gonderenHesap.hesapNo, -miktar);
            HesapBakiyeGuncelle(gonderilenHesap.hesapNo, miktar);

            db.GecmisIslemlereGonder(gonderenHesap.musteriNo, gonderilenHesap.musteriNo, gonderenHesap.hesapNo, gonderilenHesap.hesapNo, miktar, "GELEN");
            db.GecmisIslemlereGonder(gonderenHesap.musteriNo, gonderilenHesap.musteriNo, gonderenHesap.hesapNo, gonderilenHesap.hesapNo, miktar, "GIDEN");
        }

        public string[] KrediBasvurulariListele()
        {
            List<DTOKredi> list = db.KrediBasvurulariListele();
            List<string> listString = new List<string>();

            listString.Add("MÜŞTERİ NO\tKREDİ MİKTARI\tVADE");

            foreach (DTOKredi basvuru in list)
            {
                listString.Add($"{basvuru.musteriNo}\t{basvuru.krediMiktari} TL\t{basvuru.vade}");
            }

            string[] ll = new string[listString.Count];

            for (int i = 0; i < listString.Count; i++)
            {
                ll[i] = listString[i].ToString();
            }

            return ll;
        }

        public void KrediBasvuruyuGetir(int musteriNo)
        {
            List<DTOHesap> hesaplar = db.HesaplariGetir();
            List<DTOKredi> list = db.KrediBasvurulariListele();
            DTOKredi basvuru = null;
            DTOHesap hesap = null;

            foreach (DTOKredi bsvr in list)
            {
                if (bsvr.musteriNo == musteriNo)
                {
                    basvuru = bsvr;

                    break;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Müşteri No: " + basvuru.musteriNo + "\nKredi Miktarı: " + basvuru.krediMiktari +
                "\nVade: " + basvuru.vade + "\nOnaylıyor musunuz?", "ONAY EKRANI", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                double faizOrani = 0.03;
                double prntz = Math.Pow((1 + faizOrani), basvuru.vade);
                double aylikTutar = ((double)(basvuru.krediMiktari) * (prntz) * faizOrani) / ((prntz) - 1);

                foreach (DTOHesap hesapp in hesaplar)
                {
                    if (hesapp.musteriNo == basvuru.musteriNo && hesapp.dovizCinsi == "TRY" && hesapp.durumKodu)
                    {
                        hesap = hesapp;

                        db.HesapBakiyeGuncelle(hesapp.hesapNo, basvuru.krediMiktari);

                        break;
                    }
                }

                db.OnaylananKredilereGonder(basvuru.musteriNo, basvuru.krediMiktari, Convert.ToDecimal(aylikTutar), Convert.ToInt16(basvuru.vade), 0, DateTime.Today);

                db.KrediBasvurularindanSil(basvuru.musteriNo, basvuru.krediMiktari);

                db.GecmisIslemlereGonder(19999999, basvuru.musteriNo, 19999999, hesap.hesapNo, basvuru.krediMiktari, "KREDI");

                MessageBox.Show("Kredi Talebi Onaylandı.");
            }

            else if (dialogResult == DialogResult.Cancel)
            {
                db.KrediBasvurularindanSil(basvuru.musteriNo, basvuru.krediMiktari);

                MessageBox.Show("Kredi Başvurusu Silindi.");
            }
        }

        public void HesapAktiflikGuncelle(int hesap_no, bool kontrol)
        {
            db.HesapAktiflikGuncelle(hesap_no, kontrol);
        }
    }
}
