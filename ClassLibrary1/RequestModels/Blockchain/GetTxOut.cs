using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetTxOut
    {
        public string Txid { get; set; }
        public int VoutNumber { get; set; }
        public bool IncludeTheMemPool { get; set; }
    }
}
