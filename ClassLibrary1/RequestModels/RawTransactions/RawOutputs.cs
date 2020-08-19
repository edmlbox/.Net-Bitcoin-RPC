using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    public class RawOutputs
    {
        public List<RawOutput> Outputs { get; } = new List<RawOutput>();
        public string HexEncodedData { get; set; }
    }
}
