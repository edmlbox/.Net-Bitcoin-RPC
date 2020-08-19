using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class SetLabel
    {
        public string Address { get; set; }
        public string Label { get; set; }
    }
}
