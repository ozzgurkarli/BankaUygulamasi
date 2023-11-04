using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Common.DTO
{
    public class DTOGiris
    {
        public string tckn { get; set; }
        public string parola { get; set; }

        public DTOGiris() { }

        public DTOGiris(string tckn, string parola)
        {
            this.tckn = tckn;
            this.parola = parola;
        }
    }
}
