using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Variety  // grape variety
    {
        private int varietyID;
        private string varietyName;
        public int VarietyID { get; set; }
        public string VarietyName { get; set; }

        public Variety(int varietyID, string varietyName)
        {
           VarietyID = varietyID;
           VarietyName = varietyName;
        }

        public override string ToString()
        {
            return $"{VarietyName}";
        }
    }
}
