
using BitcoinRpc.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetBlockStats
    {
        public List<BlockStatsFilter> BlockStatsFilter { get; set; }
        public string[] Stats { get; set; }
        public string BlockHash { get; set; }
        public int Height { get; set; }
    }
}
