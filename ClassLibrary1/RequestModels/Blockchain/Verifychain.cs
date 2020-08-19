using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class Verifychain
    {
        public int CheckLevel { get; set; }
        public int NBlocks { get; set; }
    }
}
