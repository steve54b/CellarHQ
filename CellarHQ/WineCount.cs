using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineCount
    {
        private int wineID;
        private int currentCount;
        private int highCount;
        private int lowCount;
        public int WineID { get; }
        public int CurrentCount { get; set; }
        public int HighCount { get; set; }
        public int LowCount { get; set; }

        public WineCount(int wineID, int currentCount=0, int highCount=0,
            int lowCount=0)
        {
            WineID = wineID;
            CurrentCount = currentCount;
            HighCount = highCount;
            LowCount = lowCount;
        }
    }
}
