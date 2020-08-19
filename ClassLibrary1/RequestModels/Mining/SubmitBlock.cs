using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Mining
{
    class SubmitBlock
    {
        public string HexData { get; set; }
        public string Dummy { get; set; }
    }
}
