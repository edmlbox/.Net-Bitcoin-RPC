
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
    class AddMultisigAddress
    {
        public int NRequired { get; set; }
        public List<string> Keys { get; set; }
        public string Label { get; set; }
        public AddressType? AddressType { get; set; }
    }
}
