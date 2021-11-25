using CryptoPrice;
using System;
using System.Collections.Generic;
using System.Net;

namespace CryptoPrice
{
    public class CryptoPrice
    {
        protected WebClient _webClient;
        protected String API_URL = "https://api.nomics.com/v1/currencies/ticker?key={0}&ids={1}&convert=USD&per-page=100&page=1";
        protected String API_KEY = "7c9761d7177d7a673dc03035b680b08acc9023fc";
        protected String BACKUP_API_KEY = "7c9761d7177d7a673dc03035b680b08acc9023fc";

        public CryptoPrice(String ApiKey)
        {
            API_KEY = ApiKey;
            _webClient = new WebClient();

            if (API_KEY == "" || API_KEY == null)
                API_KEY = BACKUP_API_KEY;
        }

        public double GetCryptoPrice(String Symbol = "BTC")
        {
            return GetCoinPrice(Symbol);
        }

        protected double GetCoinPrice(String Symbol)
        {
            String request = String.Format(API_URL, API_KEY, Symbol);
            String GetLatest = _webClient.DownloadString(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return Convert.ToDouble(listRoot[0].price);
        }
    }
}
