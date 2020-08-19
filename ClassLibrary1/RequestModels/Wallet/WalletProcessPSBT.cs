
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletProcessPSBT
    {
        public string PSBT { get; set; }
        public bool? Sign { get; set; }
        public SigHashType? SigHashType { get; set; }
        public bool? Bip32Derivs { get; set; }
    }
}
