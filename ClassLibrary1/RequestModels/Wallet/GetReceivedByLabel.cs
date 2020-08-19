using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class GetReceivedByLabel
    {
        public string Label { get; set; }
        public int? MinConf { get; set; }
    }
}
