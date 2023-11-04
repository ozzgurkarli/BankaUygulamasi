using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Serv
{
    public class Deneme
    {
        public Dictionary<string, double> usd { get; set; }

    }
    public class Doviz
    {

        public static Dictionary<string, double> birim = new Dictionary<string, double>();
        public static async Task DovizYukle()
        {

            List<Deneme> xx = new List<Deneme>();
            HttpClient client = new HttpClient();
            string price = await client.GetStringAsync($"https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/usd.json");
            Deneme result = JsonConvert.DeserializeObject<Deneme>(price);
            Dictionary<string, double> birimxx = result.usd;
            birim.Add("TRY", Convert.ToDouble(birimxx["try"].ToString("0.00")));
            birim.Add("EUR", Convert.ToDouble(birimxx["eur"].ToString("0.00")));
            birim.Add("USD", 1);
            birim.Add("RUB", Convert.ToDouble(birimxx["rub"].ToString("0.00")));
            birim.Add("JPY", Convert.ToDouble(birimxx["jpy"].ToString("0.00")));
            birim.Add("GBP", Convert.ToDouble(birimxx["gbp"].ToString("0.00")));
            birim.Add("CHF", Convert.ToDouble(birimxx["chf"].ToString("0.00")));
            birim.Add("CAD", Convert.ToDouble(birimxx["cad"].ToString("0.00")));
            birim.Add("BRL", Convert.ToDouble(birimxx["brl"].ToString("0.00")));
        }
    }
}
