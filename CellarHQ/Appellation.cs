using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Appellation
    {
        private int countryID;
        private int regionID;
        private int appellationID;
        private string appellationName;

        public int CountryID { get; set; }
        public int RegionID { get; set; }
        public int AppellationID { get; set; }
        public string AppellationName { get; set; }

        public Appellation( int countryID, int regionID, int appellationID, string appellationName)
        {
            CountryID = countryID;
            RegionID = regionID;
            AppellationID = appellationID;
            AppellationName = appellationName;
        }

    }
}
