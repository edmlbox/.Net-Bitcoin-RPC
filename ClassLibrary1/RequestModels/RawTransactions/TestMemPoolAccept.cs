using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class TestMemPoolAccept
    {
        public List<string> RawTxs { get; set; }
        public string RawTx { get; set; }
        public object MaxFeeRate { get; set; }
    }
}
