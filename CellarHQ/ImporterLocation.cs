using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class ImporterLocation
    {
        private int importerID;
        private string location;
        public int ImporterID { get; set; }
        public string Location { get; set; }

        public ImporterLocation(int importerID, string location)
        {
            ImporterID = importerID;
            Location = location;
        }
    }
}
