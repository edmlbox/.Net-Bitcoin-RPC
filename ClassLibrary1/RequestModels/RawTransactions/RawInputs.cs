using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class RawInputs
    {
        public List<RawInput> Inputs { get; } = new List<RawInput>();
    }
}
