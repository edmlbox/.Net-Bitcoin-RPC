using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletName
    {
        [JsonPropertyName("wallets")]
        public List<Wllt> Wallets { get; set; }
    }
}
