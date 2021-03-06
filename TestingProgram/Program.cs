using System;
using System.Collections.Generic;
using System.Text;
using CryptoPrice;
using CryptoPrice.Currencies;
using CryptoPrice.Models;

namespace TestNugets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalize the library by passing your API key into it.
            CryptoCore _CryptoPrice = new CryptoCore("");

            //Set the currency for the price return - Default is USD.
            _CryptoPrice.SetCurrency = Fiat.EUR;
            //Get the current price of Bitcoin
            //double BitcoinPrice = _CryptoPrice.GetCryptoPrice("BTC");

            //String[] symbols = { "BTC", "ETH", "MANA", "GALA", "BNB" };
            PriceList list = _CryptoPrice.GetCryptoPrices();

            foreach (var detail in list.Prices)
                Console.WriteLine(String.Format("{0} - {1}", detail.Symbol, detail.Price));

            //Output to console
            //Console.WriteLine(BitcoinPrice);

            #region create blocks of code
            //List<String> Finished = new List<string>();

            //foreach (String line in System.IO.File.ReadLines(@"C:\Source\CryptoPrice\TestingProgram\CryptoCurrencies.txt"))
            //{
            //    if (Finished.Contains(line) == false)
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        sb.Append(String.Format("public static String {0}", line));
            //        sb.Append("{");
            //        String code = "get { return \"%%\"; }";
            //        code = code.Replace("%%", line);
            //        sb.Append(code);
            //        sb.Append("}");

            //        Finished.Add(line);
            //        Console.WriteLine(sb);
            //    }
            //}
            #endregion
        }
    }
}
