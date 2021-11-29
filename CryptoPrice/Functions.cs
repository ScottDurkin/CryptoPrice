using CryptoPrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPrice
{
    internal class Functions
    {
        /// <summary>
        /// Builds the API URL without having to reuse code
        /// </summary>
        /// <param name="pAPI_URL"></param>
        /// <param name="pAPI_KEY"></param>
        /// <param name="pSymbol"></param>
        /// <param name="pSettings"></param>
        /// <returns></returns>
        public static String BuildAPI_URL(String pAPI_URL, String pAPI_KEY, String pSymbol, LibSettings pSettings)
        {
            return String.Format(pAPI_URL, pAPI_KEY, pSymbol, pSettings.Currency, pSettings.MaxReturn);
        }
    }
}
