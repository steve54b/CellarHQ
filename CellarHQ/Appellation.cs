using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Appellation
    {
        private Country countryName;
        private string appellationName;

        public Country CountryName { get; set; }
        public string AppellationName { get; set; }

        public Appellation(Country countryName, string appellationName)
        {
            CountryName = countryName;
            AppellationName = appellationName;
        }

    }
}
