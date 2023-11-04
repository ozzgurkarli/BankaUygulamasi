using BankaUygulamasi.Common.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Data
{
    public class DAL
    {
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        Random rnd = new Random();
        DataTable da = new DataTable();


        public DAL() { }

        public List<DTOGiris> AdminKontrolu(string tckn, string parola)
        {
            List<DTOGiris> list = new List<DTOGiris>();

            da = ds.AdminKontrol(tckn, parola);

            for (int i = 0; i < da.Rows.Count; i++)
            {
                DTOGiris adm = new DTOGiris(da.Rows[i]["TCKN"].ToString(), da.Rows[i]["PAROLA"].ToString());

                list.Add(adm);
            }

            return list;
        }

        public List<DTOGiris> MusteriKontrolu(string tckn, string parola)
        {
            List<DTOGiris> list = new List<DTOGiris>();

            da = ds.MusteriKontrol(tckn, parola);

            for (int i = 0; i < da.Rows.Count; i++)
            {
                DTOGiris adm = new DTOGiris(da.Rows[i]["TCKN"].ToString(), da.Rows[i]["PAROLA"].ToString());

                list.Add(adm);
            }

            return list;
        }

        public DTOMusteri DTOMusteriDoldur(string tckn)
        {
            da = ds.MusteriDTODoldur(tckn);

            if (da.Rows.Count != 0)
            {
                DTOMusteri DTOmusteri = new DTOMusteri(Convert.ToInt32(da.Rows[0][0]), da.Rows[0][1].ToString(), da.Rows[0][3].ToString(), da.Rows[0][4].ToString(), da.Rows[0][5].ToString(), da.Rows[0][6].ToString(), da.Rows[0][7].ToString(), da.Rows[0][8].ToString(), da.Rows[0][9].ToString());

                return DTOmusteri;
            }

            return null;
        }

        public DTOMusteri DTOMusteriDoldurMusteriNoIle(int musteriNo)
        {
            da = ds.MusteriDTODoldurMusteriNoIle(musteriNo);

            if (da.Rows.Count != 0)
            {
                DTOMusteri DTOmusteri = new DTOMusteri(Convert.ToInt32(da.Rows[0][0]), da.Rows[0][1].ToString(), da.Rows[0][3].ToString(), da.Rows[0][4].ToString(), da.Rows[0][5].ToString(), da.Rows[0][6].ToString(), da.Rows[0][7].ToString(), da.Rows[0][8].ToString(), da.Rows[0][9].ToString());

                return DTOmusteri;
            }

            return null;
        }

        public List<DTOKredi> KredileriGetir()
        {
            List<DTOKredi> list = new List<DTOKredi>();

            da = ds.OnaylananKredileriGetir();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                DTOKredi adm = new DTOKredi(Convert.ToInt32(da.Rows[i]["MUSTERI_NO"]), Convert.ToDecimal(da.Rows[i]["KREDI_MIKTARI"]), Convert.ToDecimal(da.Rows[i]["AYLIK_ODEME"]),
                    Convert.ToInt32(da.Rows[i]["VADE"]), Convert.ToInt32(da.Rows[i]["ODENEN_TAKSIT"]), Convert.ToDateTime(da.Rows[i]["SON_TARIH"]));

                list.Add(adm);
            }

            return list;
        }

        public void KrediBorcuOde(DateTime date, int musteriNo, decimal krediMiktari)
        {
            ds.KrediBorcuOde(date, musteriNo, krediMiktari);
        }

        public void BitenKrediyiSil(int musteriNo, decimal krediMiktari)
        {
            ds.BitenKrediyiSil(musteriNo, krediMiktari);
        }

        public void GecmisIslemlereGonder(int gonderen_musteri, int gonderilen_musteri, int gonderen_hesap, int gonderilen_hesap, decimal miktar, string bilgi)
        {
            ds.GecmisIslemlereGonder(gonderen_musteri, gonderilen_musteri, gonderen_hesap, gonderilen_hesap, miktar, bilgi, DateTime.Now);
        }

        public List<DTOHesap> HesaplariGetir()
        {
            List<DTOHesap> list = new List<DTOHesap>();

            DTOHesap hesap;

            da = ds.HesaplariGetir();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                hesap = new DTOHesap(Convert.ToInt32(da.Rows[i]["MUSTERI_NO"]), Convert.ToInt32(da.Rows[i]["HESAP_NO"]),
                    da.Rows[i]["DOVIZ_CINSI"].ToString(), Convert.ToDecimal(da.Rows[i]["MIKTAR"]), Convert.ToBoolean(da.Rows[i]["DURUM_BILGISI"]));

                list.Add(hesap);
            }

            return list;
        }

        public DTOHesap HesapDetayGetir(int hesapNo)
        {
            da = ds.HesapDetayGetir(hesapNo);

            DTOHesap hesap = new DTOHesap(Convert.ToInt32(da.Rows[0][0]), Convert.ToInt32(da.Rows[0][1]),
                da.Rows[0][2].ToString(), Convert.ToDecimal(da.Rows[0][3]), Convert.ToBoolean(da.Rows[0][4]));

            return hesap;
        }

        public void HesapBakiyeGuncelle(int hesapNo, decimal miktar)
        {
            ds.HesapBakiyeGuncelle(miktar, hesapNo);
        }

        public int TarihFarkiniAl()
        {
            da = ds.TarihiAl();

            int gunFarki = DateTime.Today.Subtract(Convert.ToDateTime(da.Rows[0][0])).Days;

            return gunFarki;
        }

        public void FaturaOlustur(DateTime son_odeme)
        {
            List<DTOFatura> list = new List<DTOFatura>();

            DTOFatura fatura;

            da = ds.FaturaBilgileriniGetir();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                FaturaTablosunaGonder(Convert.ToInt32(da.Rows[i][0]), Convert.ToInt32(da.Rows[i][1]), da.Rows[i][2].ToString(),
                    rnd.Next(100000000, 999999999).ToString(), rnd.Next(100, 700), Convert.ToBoolean(da.Rows[i][4]), son_odeme, false);
            }
        }

        public void FaturaTablosunaGonder(int musteri_no, int hesap_no, string fatura_kodu, string fatura_no, decimal tutar, bool otomatik_odeme, DateTime son_odeme_tarihi, bool durum_kodu)
        {
            ds.FaturaTablosunaGonder(musteri_no, hesap_no, fatura_kodu, fatura_no, tutar, otomatik_odeme, son_odeme_tarihi, durum_kodu);
        }

        public void TarihiGuncelle()
        {
            ds.TarihiGuncelle(DateTime.Today);
        }

        public List<DTOFatura> FaturalariGetir()
        {
            List<DTOFatura> list = new List<DTOFatura>();
            DTOFatura fatura;

            da = ds.FaturalariGetir();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                fatura = new DTOFatura(Convert.ToInt32(da.Rows[i][0]), Convert.ToInt32(da.Rows[i][1]), da.Rows[i][2].ToString(), da.Rows[i][3].ToString(), Convert.ToDecimal(da.Rows[i][4]),
                    Convert.ToBoolean(da.Rows[i][5]), Convert.ToDateTime(da.Rows[i][6]), Convert.ToBoolean(da.Rows[i][7]));

                list.Add(fatura);
            }

            return list;
        }

        public void FaturaDurumOdendi(string fatura_no)
        {
            ds.FaturaDurumOdendi(fatura_no);
        }

        public List<DTOGecmisIslemler> GecmisIslemleriGetir()
        {
            List<DTOGecmisIslemler> list = new List<DTOGecmisIslemler>();
            DTOGecmisIslemler islem;

            da = ds.GecmisIslemleriGetir();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                islem = new DTOGecmisIslemler(Convert.ToInt32(da.Rows[i][0]), Convert.ToInt32(da.Rows[i][1]), Convert.ToInt32(da.Rows[i][2]), Convert.ToInt32(da.Rows[i][3]),
                    Convert.ToInt32(da.Rows[i][4]), Convert.ToDecimal(da.Rows[i][5]), da.Rows[i][6].ToString(), Convert.ToDateTime(da.Rows[i][7]));

                list.Add(islem);
            }

            return list;
        }

        public void HesapOlustur(int musteriNo, string dovizCinsi)
        {
            ds.SonHesapNoArtir(dovizCinsi);

            da = ds.SonHesapNoGetir(dovizCinsi);

            ds.HesaplarTablosunaEkle(musteriNo, Convert.ToInt32(da.Rows[0][0]), dovizCinsi);
        }

        public void KrediBasvuruGonder(int musteriNo, int krediMiktari, int vade)
        {
            ds.KrediBasvuruGonder(musteriNo, krediMiktari, Convert.ToInt16(vade));
        }

        public void FaturaBilgisiKaydet(int musteri_no, int hesap_no, string fatura_kod, string abone_no, bool otomatik_odeme)
        {
            ds.FaturaBilgisiKaydet(musteri_no, hesap_no, fatura_kod, abone_no, otomatik_odeme);
        }

        public void ParolaDegistir(string tckn, string parola)
        {
            ds.ParolaDegistir(parola, tckn);
        }

        public List<DTOParametreler> ParametreleriGetir()
        {
            List<DTOParametreler> list = new List<DTOParametreler>();
            DTOParametreler parametre;

            da = ds.ParametreleriAl();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                parametre = new DTOParametreler(da.Rows[i][0].ToString(), da.Rows[i][1].ToString(), da.Rows[i][2].ToString(), da.Rows[i][3].ToString());

                list.Add(parametre);
            }

            return list;
        }

        public void MusteriOlustur(string tckn, string parola, string ad, string soyad, string baba_ad, string dogum_tarihi, string cinsiyet, string kayitli_il, string kayitli_ilce, DateTime kayit_tarihi)
        {
            ds.MusteriOlustur(tckn, parola, ad, soyad, baba_ad, dogum_tarihi, cinsiyet, kayitli_il, kayitli_ilce, kayit_tarihi);
        }

        public void MusteriGuncelle(string tckn, string ad, string soyad, string baba_ad, string dogum_tarihi, string cinsiyet, string kayitli_il, string kayitli_ilce, int musteri_no)
        {
            ds.MusteriGuncelle(tckn, ad, soyad, baba_ad, dogum_tarihi, cinsiyet, kayitli_il, kayitli_ilce, musteri_no);
        }

        public List<DTOKredi> KrediBasvurulariListele()
        {
            List<DTOKredi> list = new List<DTOKredi>();
            DTOKredi basvuru;
            da = ds.KrediBasvurulariListele();

            for (int i = 0; i < da.Rows.Count; i++)
            {
                basvuru = new DTOKredi(Convert.ToInt32(da.Rows[i][0]), Convert.ToInt32(da.Rows[i][1]), Convert.ToInt32(da.Rows[i][2]));

                list.Add(basvuru);
            }

            return list;
        }

        public void OnaylananKredilereGonder(int musteri_no, decimal kredi_miktari, decimal aylik_odeme, short vade, short odenen_taksit, DateTime son_tarih)
        {
            ds.OnaylananKredilereGonder(musteri_no, kredi_miktari, aylik_odeme, vade, odenen_taksit, son_tarih);
        }

        public void KrediBasvurularindanSil(int musteri_no, decimal kredi_miktari)
        {
            ds.KrediBasvurularindanSil(musteri_no, kredi_miktari);
        }

        public void HesapAktiflikGuncelle(int hesap_no, bool kontrol)
        {
            ds.HesapAktiflikGuncelle(kontrol, hesap_no);
        }
    }
}
