using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class SignMessage
    {
        public string Address { get; set; }
        public string Message { get; set; }
    }
}
