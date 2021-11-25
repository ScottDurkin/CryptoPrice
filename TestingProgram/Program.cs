using System;
using CryptoPrice;
using CryptoPrice.Definitions;
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
            double BitcoinPrice = _CryptoPrice.GetCryptoPrice("BTC");

            //Output to console
            Console.WriteLine(BitcoinPrice);
        }
    }
}
