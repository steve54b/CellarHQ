using System;
using System.Collections.Generic;
using System.Text;

namespace CellarHQ
{
    class Producer
    {
        private string producerName;
        public string ProducerName { get; set; }

        public Producer(string producerName)
        {
            ProducerName = producerName;
        }
    }
}
