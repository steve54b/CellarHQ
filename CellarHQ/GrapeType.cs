using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class GrapeType
    {
        private int grapeTypeID;
        private string grapeTypeName;
        public int GrapeTypeID { get; set; }
        public string GrapeTypeName { get; set; }

        public Grape(int grapeTypeID, string grapeTypeName)
        {
            GrapeTypeID = grapeTypeID;
            GrapeTypeName = grapeTypeName;
        }
    }
}
