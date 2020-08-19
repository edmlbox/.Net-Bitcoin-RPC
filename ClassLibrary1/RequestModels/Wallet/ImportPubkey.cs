using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ImportPubkey
    {
        public string PubKey { get; set; }
        public string Label { get; set; }
        public bool? Rescan { get; set; }
    }
}
