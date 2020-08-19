using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class PruneBlockChain
    {
        public int Height { get; set; }
        public long UnixTimestamp { get; set; }
    }
}
