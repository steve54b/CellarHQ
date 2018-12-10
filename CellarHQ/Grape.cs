using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Grape
    {
        private int grapeID;
        private string grapeName;
        public int GrapeID { get; set; }
        public string GrapeName { get; set; }

        public Grape(int grapeID, string grapeName)
        {
            GrapeID = grapeID;
            GrapeName = grapeName;
        }
    }
}
