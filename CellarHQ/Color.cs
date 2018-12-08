using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Color
    {
        private string colorName;
        public string ColorName { get; set; }

        public Color(string colorName)
        {
            ColorName = colorName;
        }
    }
}
