using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetBlockFilter
    {
        public string Blockhash { get; set; }
        public string FilterType { get; set; }
    }
}
