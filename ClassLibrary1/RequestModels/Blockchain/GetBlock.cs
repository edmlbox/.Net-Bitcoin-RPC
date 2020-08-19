
using BitcoinRpc.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetBlock
    {
        public string Blockhash { get; set; }
        public Verbosity Verbosity { get; set; }
    }
}
