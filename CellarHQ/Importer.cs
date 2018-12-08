using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Importer
    {
        private int importerID;
        private string importerName;
        public int ImporterID { get; }
        public string ImporterName;

        public Importer(int importerID, string importerName)
        {
            ImporterID = importerID;
            ImporterName = importerName;
        }
    }
}
