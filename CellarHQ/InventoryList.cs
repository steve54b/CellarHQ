using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class InventoryList
    {
        public List<WineProfile> inventoryList = new List<WineProfile>();

        public InventoryList()
        {
            List<WineProfile> inventoryList = new List<WineProfile>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
