using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
   public class SigopLimit
    {
        public bool? SigopLimitBoolean { get; set; }
        public int? SigopLimitNumber { get; set; }
        public SigopLimit(bool? sigopLimit)
        {
            this.SigopLimitBoolean = sigopLimit;
        }

        public SigopLimit(int sigopLimit)
        {
            this.SigopLimitNumber = sigopLimit;
        }
    }
}
