
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
    class SetWalletFlag
    {
        public Flag Flag { get; set; }
        public bool Value { get; set; }
    }
}
