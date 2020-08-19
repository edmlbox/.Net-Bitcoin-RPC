using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class CreateRawTransaction
    {
        public RawInputs RawInputs { get; set; }
        public RawOutputs RawOutputs { get; set; }
        public int Locktime { get; set; }
        public bool Replaceable { get; set; }
    }
}
