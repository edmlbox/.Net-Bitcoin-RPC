using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Wallet
{
    class SetHDSeed
    {
        public bool NewKeypool { get; set; }
        public string Seed { get; set; }
    }
}
