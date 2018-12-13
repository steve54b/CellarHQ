using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Country
    {
        private int countryID;
        private string countryName;
        public int CountryID;
        public string CountryName { get; set; }

        public Country(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

    }
}
