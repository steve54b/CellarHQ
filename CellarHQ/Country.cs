using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Country
    {
        private string countryName;
        public string CountryName { get; set; }

        public Country(string countryName)
        {
            CountryName = countryName;
        }

    }
}
