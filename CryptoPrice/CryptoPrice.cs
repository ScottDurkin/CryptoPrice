using CryptoPrice;
using CryptoPrice.Currencies;
using CryptoPrice.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

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

        /// <summary>
        /// Get a single crypto price by passing in the symbol.
        /// </summary>
        /// <param name="Symbol">Default: BTC</param>
        /// <returns>The price of any crypto symbol you give.</returns>
        public double GetCryptoPrice(String Symbol = "BTC")
        {
            return GetCoinPrice(Symbol);
        }

        /// <summary>
        /// Get a single crypto price by passing in the symbol.
        /// </summary>
        /// <param name="Symbol"></param>
        /// <returns>The price of the crypto symbol as a string. Perfect for Alt coins.</returns>
        public String GetCryptoPriceString(String Symbol = "BTC")
        {
            return GetCoinPriceStr(Symbol);
        }

        /// <summary>
        /// Get a Crypto Price with Async
        /// </summary>
        /// <param name="Symbol"></param>
        /// <returns></returns>
        public async Task<double> GetCryptoPriceAsync(String Symbol = "BTC")
        {
            return await GetCoinPriceAsync(Symbol);
        }

        /// <summary>
        /// Get a Crypto Price with Async
        /// </summary>
        /// <param name="Symbol"></param>
        /// <returns></returns>
        public async Task<String> GetCryptoPriceStringAsync(String Symbol = "BTC")
        {
            return await GetCoinPriceStringAsync(Symbol);
        }

        /// <summary>
        /// Get the market cap of a coin
        /// </summary>
        /// <param name="Symbol">Example: BTC</param>
        /// <returns>The Market cap of the coin symbol</returns>
        public double GetMarketCap(String Symbol = "BTC")
        {
            return GetCoinMarketCap(Symbol);
        }

        /// <summary>
        /// Get a full list of prices by just passing in a string array of symbols.
        /// </summary>
        /// <param name="Symbols">Default: BTC, ETH</param>
        /// <returns>A PriceList model, with a list of PriceDetails.</returns>
        public PriceList GetCryptoPrices(String[] Symbols = null)
        {
            Symbols = Symbols ?? DefaultSymbols;

            String join = String.Join(",", Symbols);

            return GetCoinPrices(join);
        }

        /// <summary>
        /// Get a full list of prices by just passing in a string array of symbols.
        /// </summary>
        /// <param name="Symbols">Default: BTC, ETH</param>
        /// <returns>A PriceList model, with a list of PriceDetails.</returns>
        public async Task<PriceList> GetCryptoPricesAsync(String[] Symbols = null)
        {
            Symbols = Symbols ?? DefaultSymbols;

            String join = String.Join(",", Symbols);

            return await GetCoinPricesAsync(join);
        }

        public String FormatPrice(double price = 54356)
        {
            String rc = String.Empty;
            String currencySym = String.Empty;
            Symbol.Get.TryGetValue(_Settings.Currency, out currencySym);

            return String.Format("{0}{1}", currencySym, price.ToString("N"));
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Protected functions that are used by public functions
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Get a single coin price
        protected double GetCoinPrice(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = _webClient.DownloadString(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return Convert.ToDouble(listRoot[0].price);
        }

        protected String GetCoinPriceStr(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = _webClient.DownloadString(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return listRoot[0].price;
        }

        //Get a single coin price
        protected async Task<double> GetCoinPriceAsync(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = await _webClient.DownloadStringTaskAsync(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return Convert.ToDouble(listRoot[0].price);
        }

        //Get a single coin price
        protected async Task<String> GetCoinPriceStringAsync(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = await _webClient.DownloadStringTaskAsync(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return listRoot[0].price;
        }

        //Get a single coin market cap
        protected double GetCoinMarketCap(String Symbol)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbol, _Settings);
            String GetLatest = _webClient.DownloadString(request);

            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            return Convert.ToDouble(listRoot[0].market_cap);
        }

        //Get a list of coin prices
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
                temp.MarketCap = Convert.ToDouble(coin.market_cap);

                list.Prices.Add(temp);
            }

            return list;
        }

        //Get a list of coin prices
        protected async Task<PriceList> GetCoinPricesAsync(String Symbols)
        {
            String request = Functions.BuildAPI_URL(API_URL, API_KEY, Symbols, _Settings);
            String GetLatest = await _webClient.DownloadStringTaskAsync(request);
            List<Root> listRoot = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Root>>(GetLatest);

            PriceList list = new PriceList();

            foreach (var coin in listRoot)
            {
                PriceDetails temp = new PriceDetails();
                temp.Symbol = coin.symbol;
                temp.Price = Convert.ToDouble(coin.price);
                temp.MarketCap = Convert.ToDouble(coin.market_cap);

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
