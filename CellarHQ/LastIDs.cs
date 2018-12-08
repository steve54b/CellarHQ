using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class LastIDs
    {
        private int lastWineID;
        private int lastProducerID;
        private int lastCountryID;
        private int lastRegionID;
        private int lastAppellationID;
        private int lastVarietalID;
        private int lastMerchantID;
        private int lastImporterID;

        public int LastWineID { get; set; }
        public int LastCountryID { get; set; }
        public int LastRegionID { get; set; }
        public int LastAppellationID { get; set; }
        public int LastVarietalID { get; set; }
        public int LastMerchantID { get; set; }
        public int LastImporterID { get; set; }
    }
}
