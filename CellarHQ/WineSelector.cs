using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class WineSelector
    {
        private string wineSelectorName;
        public string WineSelectorName { get; set; }

        public WineSelector(string wineSelectorName)
        {
            WineSelectorName = wineSelectorName;
        }
    }
}
