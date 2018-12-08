using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Dryness
    {
        private string drynessType;
        public string DrynessType { get; set; }

        public Dryness(string drynessType)
        {
            DrynessType = drynessType;
        }
    }
}
