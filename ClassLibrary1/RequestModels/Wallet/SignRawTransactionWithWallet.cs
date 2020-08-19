
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.RawTransactions;

namespace BitcoinRpc.RequestModels.Wallet
{
    class SignRawTransactionWithWallet
    {
        public string HexString { get; set; }
        public List<PrevTxs> PrevTxs { get; set; }
        public SigHashType? SigHashType { get; set; }
    }
}
