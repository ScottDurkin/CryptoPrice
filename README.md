# About CryptoPrice

Cryptocurrency is hot right now. It remains unclear how it will perform in the future, but until then, it is the trending topic on the horizon. CryptoPrice is a library to obtain real-time price information on cryptocurrencies. It's .NET implementation is lightweight, fast, and easy to use.

# Get started with CryptoPrice

<b>Note: In order to use CryptoPrice, you will need to obtain a free API Key from [`nomics.com`](https://p.nomics.com/cryptocurrency-bitcoin-api)</b>

1. Insallation
.NET CLI:
```
dotnet add package CryptoPrice --version 0.0.3
```
Nuget Package:
[`https://www.nuget.org/packages/CryptoPrice/`](https://www.nuget.org/packages/CryptoPrice/)
# 

2. Once the package is installed add the following to the top of your class.
```
using CryptoPrice;
```

3. Getting the current price of Bitcoin
```c#
using System;
using CryptoPrice;
namespace TestNugets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalize the library by passing your API key into it.
            CryptoCore _CryptoPrice = new CryptoCore("YOUR_API_KEY");
            
            //Get the current price of Bitcoin
            double BitcoinPrice = _CryptoPrice.GetCryptoPrice("BTC");

            //Output to console
            Console.WriteLine(BitcoinPrice);
        }
    }
}
```
Console Output
```
58942.97387688
```

4. Configure the currecy you would like to see the price of crypto in.
```
using CryptoPrice.Currencies;
```

5. Setting the currency to Euro.
```c#
using System;
using CryptoPrice;
using CryptoPrice.Currencies;
namespace TestNugets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initalize the library by passing your API key into it.
            CryptoCore _CryptoPrice = new CryptoCore("YOUR_API_KEY");

            //Set the currency for the price return - Default is USD.
            _CryptoPrice.SetCurrency = Fiat.EUR;

            //Get the current price of Bitcoin
            double BitcoinPrice = _CryptoPrice.GetCryptoPrice("BTC");

            //Output to console
            Console.WriteLine(BitcoinPrice);
        }
    }
}
```
Console Output
```
52928.63502381
```

6. Getting a list of crypto prices
```c#
using System;
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
            CryptoCore _CryptoPrice = new CryptoCore("YOUR_API_KEY");

            //Set the currency for the price return - Default is USD.
            _CryptoPrice.SetCurrency = Fiat.USD;

            //Get a list of Crypto Prices
            String[] Symbols = { Crypto.BNB, Crypto.BTC, Crypto.CAKE, Crypto.ETH, Crypto.SOL, Crypto.GALA };
            PriceList prices = _CryptoPrice.GetCryptoPrices(Symbols);

            //Wrtie prices to console
            foreach (var detail in prices.Prices)
                Console.WriteLine(String.Format("{0} - {1}", detail.Symbol, detail.Price));
        }
    }
}
```
Console Output
```
BTC - 57433.14607099
ETH - 4345.36644844
BNB - 615.08581624
SOL - 206.49062392
GALA - 0.70083059
CAKE - 14.22022867
```

# Nuget Package
https://www.nuget.org/packages/CryptoPrice/
