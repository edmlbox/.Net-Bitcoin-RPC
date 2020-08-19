using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
    class UtxoUpdatePSBT
    {
        public string PSBT { get; set; }
        public List<string> OutputDescriptors { get; set; }
        public List<OutputDescriptor> OutputDescriptorsWithExtra { get; set; }
    }
}
