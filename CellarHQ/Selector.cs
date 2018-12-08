using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Selector
    {
        private string selectorName;
        public string SelectorName { get; set; }

        public Selector(string selectorName)
        {
            SelectorName = selectorName;
        }
    }
}
