﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ListReceivedByAddress
    {
        public int MinConf { get; set; }
        public bool IncludeEmpty { get; set; }
        public bool IncludeWatchOnly { get; set; }
        public string AddressFilter { get; set; }
    }
}
