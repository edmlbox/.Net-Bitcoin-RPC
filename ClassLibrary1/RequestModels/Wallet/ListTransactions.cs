using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class ListTransactions
    {
        public string Label { get; set; }
        public int Count { get; set; }
        public int Skip { get; set; }
        public bool IncludeWatchonly { get; set; }
    }
}
