using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
   public class SizeLimit
    {
        public bool? SizeLimitBoolean { get; set; }
        public int? SizeLimitNumber { get; set; }

        public SizeLimit(bool? sizeLimit)
        {
            this.SizeLimitBoolean = sizeLimit;
        }

        public SizeLimit(int sizeLimit)
        {
            this.SizeLimitNumber = sizeLimit;
        }
    }
}
