using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class MerchantLocation
    {
        private Merchant merchantName;
        private string location;

        public Merchant MerchantName { get; set; }
        public string Location { get; set; }

        public MerchantLocation(Merchant merchantname, string location)
        {
            MerchantName = merchantname;
            Location = location;
        }

    }
}
