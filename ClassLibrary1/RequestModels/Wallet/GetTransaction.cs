using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class GetTransaction
    {
        public string Txid { get; set; }
        public bool? IncludeWatchOnly { get; set; }
        public bool? IncludeDecoded { get; set; }
    }
}
