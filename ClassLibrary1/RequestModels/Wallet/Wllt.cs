using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Text.Json.Serialization;

namespace BitcoinRpc.RequestModels.Wallet
{
   public class Wllt
    {
       [JsonPropertyName("name")]
       public string Name { get; set; }
    }
}
