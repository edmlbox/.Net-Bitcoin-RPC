using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Util
{
    class VerifyMessage
    {
        public string Address { get; set; }
        public string Signature { get; set; }
        public string Message { get; set; }
    }
}
