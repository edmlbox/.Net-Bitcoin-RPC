using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
   public class TemplateTweaking
    {
        public SigopLimit SigopLimit { get; set; }
        public SizeLimit SizeLimit { get; set; }

        public int? MaxVersion { get; set; }
    }
}
