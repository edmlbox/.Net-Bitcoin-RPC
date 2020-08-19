using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class SendRawTransaction
    {
        public string HexString { get; set; }
        public bool? AllowHighFees { get; set; }
        public float? MaxFeeRate { get; set; }
    }
}
