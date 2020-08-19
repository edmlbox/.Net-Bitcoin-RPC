
using BitcoinRpc.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class GetRawTransaction
    {
        public string Txid { get; set; }
        public TXReturnType? ReturnType { get; set; }
        public string Blockhash { get; set; }

        public bool ConvertToBool(TXReturnType returnType)
        {
            return returnType == TXReturnType.String ? false : true;
        }
    }
}
