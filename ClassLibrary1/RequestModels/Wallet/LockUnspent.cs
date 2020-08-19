using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class LockUnspent
    {
        public bool Unlock { get; set; }
        public List<TransactionOutputs> TransactionOutputs { get; set; }
    }
}
