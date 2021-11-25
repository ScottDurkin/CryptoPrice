# About CryptoPrice

This projects main goal is to allow .NET developer to access real-time prices of any Cyrpto Currency, using very little code.

# Get started with CryptoPrice

<b>Note: In order to us CryptoPrice, you will need to obtain a free API Key from [`nomics.com`](https://p.nomics.com/cryptocurrency-bitcoin-api)</b>

1. Navigate to your package manager within Visual Studio and use the following command.
```
dotnet add package CryptoPrice --version 0.0.1
```
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
            CryptoPrice.CryptoPrice _CryptoPrice = new CryptoPrice.CryptoPrice("YOUR_API_KEY");
            //Get the current price of Bitcoin
            double BitcoinPrice = _CryptoPrice.GetCryptoPrice("BTC");

            //Output to console
            Console.WriteLine(BitcoinPrice);
        }
    }
}

```
4. Console output - Result will differ depending on the price at the time of your request.
```
58942.97387688
```
# Nuget Package
https://www.nuget.org/packages/CryptoPrice/
