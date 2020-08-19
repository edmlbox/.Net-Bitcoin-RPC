using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ListSinceBlock
    {
        public string Blockhash { get; set; }
        public int TargetConfirmations { get; set; }
        public bool IncludeWatchOnly { get; set; }
        public bool IncludeRemoved { get; set; }
    }
}
