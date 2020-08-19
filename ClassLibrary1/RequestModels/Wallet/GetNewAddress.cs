
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
    class GetNewAddress
    {
        public string Label { get; set; }
        public AddressType? AddressType { get; set; }
    }
}
