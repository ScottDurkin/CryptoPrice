﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPrice.Models
{
    internal class LibSettings
    {
        public String Currency { get; set; }

        internal LibSettings()
        {
            this.Currency = "USD";
        }
    }
}
