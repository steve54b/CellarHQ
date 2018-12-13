using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Appellation
    {
        private int countryID;
        private int appellationID;
        private string appellationName;
        private int regionID;
        private int subregionID;

        public int CountryID { get; set; }
        public int AppellationID { get; set; }
        public string AppellationName { get; set; }
        private int RegionID { get; set; }
        private int SubregionID { get; set; }

        public Appellation( int countryID, int appellationID, string appellationName,
            int regionID, int subregionID)
        {
            CountryID = countryID;
            AppellationID = appellationID;
            AppellationName = appellationName;
            RegionID = regionID;
            SubregionID = subregionID;
        }

    }
}
