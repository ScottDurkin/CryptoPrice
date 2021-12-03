using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPrice.Currencies
{
    public static class Symbol
    {
        public static Dictionary<String, String> Get = new Dictionary<string, string>
        {
            //Europe
            {Fiat.BGN,"лв "},
            {Fiat.CHF,"CHF "},
            {Fiat.CZK,"Kč "},
            {Fiat.DKK,"kr "},
            {Fiat.EUR,"€"},
            {Fiat.GBP,"£"},
            {Fiat.GEL,"₾"},
            {Fiat.HUF,"ft "},
            {Fiat.NOK,"kr "},
            {Fiat.PLN,"zł "},
            {Fiat.RUB,"₽"},
            {Fiat.RON,"lei "},
            {Fiat.SEK,"kr "},
            {Fiat.TRY,"₺"},
            {Fiat.UAH,"₴"},

            //Middle east & Africa
        };
    }
}
