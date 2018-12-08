using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Varietal
    {
        private int varietalID;
        private string varietalName;
        public int VarietalID { get; set; }
        public string VarietalName { get; set; }

        public Varietal(int varietalID, string varietalName)
        {
            VarietalID = varietalID;
            VarietalName = varietalName;
        }
    }
}
