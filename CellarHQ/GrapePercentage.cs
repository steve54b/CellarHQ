using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class GrapePercentage
    {
        private int wineID;
        private int grapeID;
        private int grapePercent;

        public int WineID { get; set; }
        public int GrapeID { get; set; }
        public int GrapePercent { get; set; }

        public GrapePercentage(int WineID, int grapeID, int grapePercent)
        {
            WineID = wineID;
            GrapeID = grapeID;
            GrapePercent = grapePercent;
        }

    }
}
