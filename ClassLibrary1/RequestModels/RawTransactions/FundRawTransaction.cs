using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class FundRawTransaction
    {
        public string HexString { get; set; }
        public FundOptions FundOptions { get; set; }
        public bool? IsWitness { get; set; }
    }
}
