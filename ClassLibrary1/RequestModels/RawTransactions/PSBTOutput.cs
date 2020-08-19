using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinRpc.RequestModels.RawTransactions
{
   public class PSBTOutput
    {
        public string Address { get; set; }
        public object Amount { get; set; }
        public PSBTOutput(string address, string amount)
        {
            this.Address = address;
            this.Amount = amount;
        }
        public PSBTOutput(string address, float amount)
        {
            this.Address = address;
            this.Amount = amount;
        }
    }
}
