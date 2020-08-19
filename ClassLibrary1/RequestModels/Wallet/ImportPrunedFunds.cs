using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ImportPrunedFunds
    {
        public string RawTransaction { get; set; }
        public string TxOutProof { get; set; }
    }
}
