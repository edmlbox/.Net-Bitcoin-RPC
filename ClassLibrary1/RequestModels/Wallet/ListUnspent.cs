using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ListUnspent
    {
        public int MinConf { get; set; }
        public int MaxConf { get; set; }
        public List<string> Addresses { get; set; }
        public bool IncludeUnsafe { get; set; }
        public QueryOptions QueryOptions { get; set; }
    }
}
