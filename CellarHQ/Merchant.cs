using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Merchant
    {
        private string merchantName;
        public string MerchantName { get; set; }

        public Merchant(string merchantname)
        {
            MerchantName = merchantname;
        }
    }
}
