using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Util
{
    class DeriveAddresses
    {
        public string Descriptor { get; set; }


        public int? BeginRange { get; set; }
        public int? EndRange { get; set; }
    }
}
