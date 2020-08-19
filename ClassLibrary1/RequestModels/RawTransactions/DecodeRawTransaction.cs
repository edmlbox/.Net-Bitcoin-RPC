using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class DecodeRawTransaction
    {
        public string HexString { get; set; }
        public bool? IsWitness { get; set; }
    }
}
