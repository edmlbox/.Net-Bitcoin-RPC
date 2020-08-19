
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Control
{
    class Logging
    {
        public List<LoggingCategories> Include { get; set; }
        public List<LoggingCategories> Exclude { get; set; }
    }
}
