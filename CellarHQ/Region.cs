using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Region
    {
        private int countryID;
        private int regionID;
        private string regionName;
        public int CountryID { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }

        public Region(int countryID, int regionID, string regionName)
        {
            CountryID = countryID;
            RegionID = regionID;
            RegionName = regionName;
        }

    }
}
