using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class LowestCount
    {
        private int wineID;
        private int count;
        public int WineID { get; }
        public int Count { get; set; }

        public CurrentCount(int wineID, int count)
        {
            WineID = wineID;
            Count = count;
        }
    }
}
