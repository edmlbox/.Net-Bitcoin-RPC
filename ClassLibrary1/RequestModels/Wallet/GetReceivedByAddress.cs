using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class GetReceivedByAddress
    {
        public string Address { get; set; }
        public int? MinConf { get; set; }
    }
}
