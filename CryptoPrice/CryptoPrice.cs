using CryptoPrice;
using CryptoPrice.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace CryptoPrice
{

    public class CryptoCore
    {
        protected WebClient _webClient;
        protected String API_URL = "https://api.nomics.com/v1/currencies/ticker?key={0}&ids={1}&convert={2}&per-page={3}&page=1";
        protected String API_KEY = "";
        protected String BACKUP_API_KEY = "7c9761d7177d7a673dc03035b680b08acc9023fc";

        protected String[] DefaultSymbols = { "BTC", "ETH" };

        LibSettings _Settings;

        public CryptoCore(String ApiKey)
        {
            API_KEY = ApiKey;
            _webClient = new WebClient();
            _Settings = new LibSettings();

            if (API_KEY == "" || API_KEY == null)
                API_KEY = BACKUP_API_KEY;
        }

        public double GetCryptoPrice(String Symbol = "BTC")
        {
            return GetCoinPrice(Symbol);
        }

        public PriceList GetCryptoPrices(String[] Symbols = null)
        {
            Symbols = Symbols ?? DefaultSymbols;

            String join = String.Join(",", Symbols);

            return GetCoinPrices(join);
        }

        protected double GetCoinPrice(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = _webClient.DownloadString(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return Convert.ToDouble(listRoot[0].price);
        }

        protected PriceList GetCoinPrices(String Symbols)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbols, _Settings);
            String GetLatest = _webClient.DownloadString(request);
            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            PriceList list = new PriceList();

            foreach(var coin in listRoot)
            {
                PriceDetails temp = new PriceDetails();
                temp.Symbol = coin.symbol;
                temp.Price = Convert.ToDouble(coin.price);
                list.Prices.Add(temp);
            }

            return list;
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Settings
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Set the currency you would like to see your results come back in.
        /// Note: You can use crypto currency symbols as well.
        /// </summary>
        public String SetCurrency
        {
            set
            {
                _Settings.Currency = value;
            }
        }

        public int SetMaxReturn
        {
            set
            {
                _Settings.MaxReturn = value;
            }
        }
    }
}
