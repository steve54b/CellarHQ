using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineType
    {
        private string typeName;
        public string TypeName { get; set; }

        public WineType(string typeName)
        {
            TypeName = typeName;
        }

    }
}
