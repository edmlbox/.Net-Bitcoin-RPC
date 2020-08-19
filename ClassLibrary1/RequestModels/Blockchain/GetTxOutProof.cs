using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetTxOutProof
    {
        public List<string> ArrayOfTxids { get; set; }
        public string Blockhash { get; set; }
    }
}
