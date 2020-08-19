using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletPassphrase
    {
        public string Passphrase { get; set; }
        public int Timeout { get; set; }
    }
}
