
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class BumpFeeOptions
    {
        public int? ConfTarget { get; set; }
        public float? FeeRate { get; set; }
        public bool? Replaceable { get; set; }
        public EstimateMode? EstimateMode { get; set; }
    }
}
