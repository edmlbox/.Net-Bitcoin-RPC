
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Blockchain
{
    class GetMemPool
    {
        public string Txid { get; set; }
        public ReturnFormat ReturnFormat { get; set; }

        public bool BlockHeaderVerbosityConverter()
        {
            bool JsonOrArray = ReturnFormat == ReturnFormat.ArrayOfTransactionIds ? false : true;
            return JsonOrArray;
        }
    }
}
