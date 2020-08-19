
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Network
{
    class AddNode
    {
        public string Node { get; set; }
        public NodeCommand NodeCommand { get; set; }
    }
}
