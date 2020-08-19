using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class ConvertToPSBT
    {
        public string HexString { get; set; }
        public bool PermitSigData { get; set; }
        public bool IsWitness { get; set; }
    }
}
