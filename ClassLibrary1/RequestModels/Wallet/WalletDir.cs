using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BitcoinRpc.RequestModels.Wallet
{
    class WalletDir
    {

        [JsonPropertyName("result")]
        public WalletName Result { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; }




    }
}
