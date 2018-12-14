using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class VarietyPercentage // one row for each grape variety in a wine profile
    {
        private int wineID;
        private int varietyID;
        private int varietyPercent;

        public int WineID { get; set; }
        public int VarietyID { get; set; }
        public int VarietyPercent { get; set; }

        public VarietyPercentage(int WineID, int varietyID, int varietyPercent)
        {
            WineID = wineID;
            VarietyID = varietyID;
            VarietyPercent = varietyPercent;
        }

        public override string ToString()  // output a row for each grape variety in a wine profile
        {
            string percentagesString = "";
            string VarietyName = "Brobdingnang Blanc";

            // 0) Select all rows from VarietyPercentages table matching WineID
            // 1) looping through all selected rows, ordered by VarietyName:
            //      a) Select VarietyName from Varieties table with match on VarietyID
            //      b) add to percentagesString, as follows:

            // BEGIN LOOP
            percentagesString += $"{VarietyName}, {VarietyPercent}";
            // END LOOP

            return percentagesString; 
        }

    }
}
