using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletPassphraseChange
    {
        public string OldPassphrase { get; set; }
        public string NewPassphrase { get; set; }
    }
}
