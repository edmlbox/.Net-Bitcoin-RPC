
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;
using BitcoinRpc.RequestModels.RawTransactions;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletCreateFundedPSBT
    {
        public List<RawInput> Inputs { get; set; }
        public List<RawOutput> OutPuts { get; set; }
        public string HexData { get; set; }

        public int? LockTime { get; set; }
        public FundOptions FundOptions { get; set; }
        public bool? Bip32Derivs { get; set; }
    }
}
