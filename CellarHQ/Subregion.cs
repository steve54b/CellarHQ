using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Subregion
    {
        private int countryID;
        private int regionID;
        private int subregionID;
        private string subregionName;
        public int CountryID { get; set; }
        public int RegionID { get; set; }
        public int SubregionID { get; set; }
        public string SubregionName { get; set; }

        public Subregion(int regionID, int subregionID, string subregionName)
        {
            CountryID = countryID;
            RegionID = regionID;
            SubregionID = subregionID;
            SubregionName = subregionName;
        }

    }
}
