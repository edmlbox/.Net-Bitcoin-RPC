using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class RescanBlockchain
    {
        public int StartHeight { get; set; }
        public int StopHeight { get; set; }
    }
}
