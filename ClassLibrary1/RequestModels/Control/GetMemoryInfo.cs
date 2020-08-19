
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Control
{
    class GetMemoryInfo
    {
        public Mode Mode { get; set; }
        public override string ToString()
        {
            return Mode.ToString().ToLower();
        }
    }
}
