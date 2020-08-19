using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Util
{
    class SignMessageWithPrivKey
    {
        public string Privkey { get; set; }
        public string Message { get; set; }
    }
}
