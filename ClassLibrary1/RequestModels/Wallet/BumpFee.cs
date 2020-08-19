using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class BumpFee
    {
        public string Txid { get; set; }
        public BumpFeeOptions BumpFeeOptions { get; set; }
    }
}
