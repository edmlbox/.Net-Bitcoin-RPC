
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Util
{
    class CreateMultisig
    {
        public int NRequired { get; set; }
        public List<string> PublicKeys { get; set; }
        public AddressType? AddressType { get; set; }
    }
}
