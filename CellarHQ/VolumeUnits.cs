using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class VolumeUnits
    {
        private string unitsName;
        public string UnitsName { get; set; }

        public VolumeUnits(string unitsName)
        {
            UnitsName = unitsName;
        }

    }
}
