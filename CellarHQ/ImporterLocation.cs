using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class ImporterLocation
    {
        private int importerID;
        private int locationID;
        private string locationCity;
        private string locationState;
        public int ImporterID { get; set; }
        public int LocationID { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }

        public ImporterLocation(int importerID, string location)
        {
            ImporterID = importerID;
            Location = location;
        }
    }
}
