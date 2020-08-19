using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class CreateWallet
    {
        public string WalletName { get; set; }
        public bool? DisablePrivateKeys { get; set; }
        public bool? Blank { get; set; }
        public string Passphrase { get; set; }
        public bool? AvoidReuse { get; set; }
    }
}
