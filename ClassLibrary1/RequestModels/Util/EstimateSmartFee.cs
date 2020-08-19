
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Util
{
    class EstimateSmartFee
    {
        public int ConfTarget { get; set; }
        public EstimateMode? EstimateMode { get; set; }
    }
}
