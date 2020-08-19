
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetBlockHeader
    {
        public string Blockhash { get; set; }
        public BlockHeaderVerbosity BlockHeaderVerbosity { get; set; }

        public bool BlockHeaderVerbosityConverter()
        {
            bool JsonOrHex = BlockHeaderVerbosity == BlockHeaderVerbosity.Hex ? false : true;
            return JsonOrHex;
        }
    }
}
