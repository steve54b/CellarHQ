using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class CurrencyType
    {
        private string countryName;
        private string currencyTypeName;
        public string CountryName;
        public string CurrencyTypeName { get; set; }

        public CurrencyType(string countryName, string currencyTypeName)
        {
            CountryName = countryName;
            CurrencyTypeName = currencyTypeName;
        }

    }
}
