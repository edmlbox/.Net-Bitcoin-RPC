using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class GetBalance
    {
        public string Dummy { get; set; }
        public int? MinConf { get; set; }
        public bool? IncludeWatchOnly { get; set; }
        public bool? AvoidReuse { get; set; }
    }
}
