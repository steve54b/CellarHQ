using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class ProducerLocation
    {
        private Producer producerName;
        private string location;

        public Producer ProducerName { get; set; }
        public string Location { get; set; }

        public ProducerLocation(Producer producerName, string location)
        {
            ProducerName = producerName;
            Location = location;
        }

    }
}
