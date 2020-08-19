using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ImportMulti
    {
        public List<MultiData> MultiData { get; set; }
        public bool? Rescan { get; set; }
    }
}
