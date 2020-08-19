using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ImportPrivKey
    {
        public string PrivKey { get; set; }
        public string Label { get; set; }
        public bool? Rescan { get; set; }
    }
}
