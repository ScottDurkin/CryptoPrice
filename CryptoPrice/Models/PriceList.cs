using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPrice.Models
{
    public class PriceDetails
    {
        public String Symbol { get; set; }
        public double Price { get; set; }
        public double MarketCap { get; set; }
    }

    public class PriceList
    {
        public List<PriceDetails> Prices { get; set; }
        public PriceList()
        {
            this.Prices = new List<PriceDetails>();
        }
    }
}
