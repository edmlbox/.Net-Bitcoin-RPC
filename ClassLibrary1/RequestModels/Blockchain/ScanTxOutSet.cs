
using System;
using System.Collections.Generic;
using System.Text;
using BitcoinRpc.Enums;

namespace BitcoinRpc.RequestModels.Blockchain
{
   public class ScanTxOutSet
    {
        public Scan Action { get; set; }
        public Descriptor Descriptor { get; set; }
        public List<string> ScanObjects { get; set; } = new List<string>();
        public override string ToString()
        {
            return Action.ToString().ToLower();
        }
    }
}
