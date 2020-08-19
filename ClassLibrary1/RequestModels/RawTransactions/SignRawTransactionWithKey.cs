
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;
namespace BitcoinRpc.RequestModels.RawTransactions
{
    class SignRawTransactionWithKey
    {
        public string Hexstring { get; set; }
        public List<string> PrivKeys { get; set; }
        public List<PrevTxs> PrevTxs { get; set; }
        public SigHashType? HashType { get; set; }
    }
}
