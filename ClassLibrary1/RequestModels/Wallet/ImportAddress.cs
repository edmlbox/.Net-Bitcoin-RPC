using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ImportAddress
    {
        public string Address { get; set; }
        public string Label { get; set; }
        public bool? Rescan { get; set; }
        public bool? P2SH { get; set; }
    }
}
