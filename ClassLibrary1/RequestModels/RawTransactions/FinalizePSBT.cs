using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class FinalizePSBT
    {
        public string PSBT { get; set; }
        public bool? Extract { get; set; }
    }
}
