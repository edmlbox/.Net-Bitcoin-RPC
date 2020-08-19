using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.Network
{
    class DisconnectNode
    {
        public string NodeAddress { get; set; }
        public int? NodeId { get; set; }
    }
}
